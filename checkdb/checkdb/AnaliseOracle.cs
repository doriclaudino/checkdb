using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
//connectionString = "User Id=" + user + ";Password=" + pass + ";Data Source=" + database;


namespace checkdb
{
    class AnaliseOracle
    {       
        OracleConnection connection;
        String connectionString = FormAnalise.connectionString;
        public List<Consulta> consultas = new List<Consulta>();


        public AnaliseOracle()
        {            
            if(connection == null)
            {
                connection = new OracleConnection(connectionString);
            }
            Connect();
            iniciaConsultas();   
        }

        public AnaliseOracle(Boolean checkAdmin)
        {            
            Connect();

            if (checkAdmin)
            {
                int privilegios = 0;
                String sql = "select 1 from user_role_privs where GRANTED_ROLE = 'DBA' or exists (select 1 from user_sys_privs where PRIVILEGE in('SELECT ANY DICTIONARY','CREATE SESSION'))";
                privilegios = getError(sql);
                if (privilegios < 1)
                    throw new InvalidProgramException("Não possui privilégio suficientes!");
                else
                    iniciaConsultas();
            }
        } 

        public void Connect()
        {
            try
            {
                if (connection == null)
                {
                    connection = new OracleConnection(connectionString);
                    connection.Open();
                }
                else
                {
                    connection.Clone();
                    connection.Dispose();                    
                    connection = new OracleConnection(connectionString);
                    connection.Open();
                }               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public List<Consulta> getConsultas()
        {
            return this.consultas;
        }

        public void iniciaConsultas()
        {

            consultas.Add(new Consulta("archivelog",
                                            "entry.289178860", 
                                            "SELECT count(1) FROM GV$DATABASE where upper(LOG_MODE) <> 'ARCHIVELOG'"));
            consultas.Add(new Consulta("option ativada",
                                                "entry.2110294689",
                                                "select count(1) from gv$option where upper(VALUE) = 'TRUE' and PARAMETER in ('Partitioning','Advanced replication','Bit-mapped indexes','Parallel backup and recovery','Parallel execution','Point-in-time tablespace recovery','Fine-grained access control','Change Data Capture','Online Index Build','Managed Standby','Materialized view rewrite','Database resource manager','Spatial','Automatic Storage Management','Export transportable tablespaces','Fast-Start Fault Recovery','Duplexed backups','Block Media Recovery','Fine-grained Auditing','Application Role','Enterprise User Security','Oracle Data Guard','Oracle Label Security','OLAP','Basic Compression','Join index','Trial Recovery','Data Mining','Online Redefinition','Streams Capture','File Mapping','Block Change Tracking','Flashback Table','Flashback Database','Transparent Data Encryption','Backup Encryption','Unused Block Compression','Oracle Database Vault','Result Cache','SQL Plan Management','SecureFiles Encryption','Real Application Testing','Active Data Guard','Server Flash Cache','Advanced Compression','Deferred Segment Creation','Data Redaction')"));
            consultas.Add(new Consulta("management pack",
                                                 "entry.457985768", 
                                                 "select count(1) from gv$parameter where upper(VALUE) <> 'NONE' and name = 'control_management_pack_access'"));
            consultas.Add(new Consulta("pga agregate",
                                         "entry.1057417099", 
                                         "select count(1) from gv$parameter where value < '536870912' and name = 'pga_aggregate_target'"));
            consultas.Add(new Consulta("recyclebin on",
                                               "entry.2069289671",
                                               "select count(1) from gv$parameter where upper(VALUE) = 'ON' and name = 'recyclebin'"));
            consultas.Add(new Consulta("optimyzer mode",
                                                "entry.1385212617",
                                                "select count(1) from gv$parameter where upper(VALUE) <> 'ALL_ROWS' and name = 'optimizer_mode'"));
            consultas.Add(new Consulta("optimyzer index cost",
                                                        "entry.1374890719",
                                                        "select count(1) from gv$parameter where value <> '30' and name = 'optimizer_index_cost_adj'"));
            consultas.Add(new Consulta("optimizer index caching",
                                        "entry.1577452013",
                                        "select count(1) from gv$parameter where value <> '70' and name = 'optimizer_index_caching'"));
            consultas.Add(new Consulta("lag target",
                                            "entry.1740525845",
                                            "select count(1) value from gv$parameter where name = 'archive_lag_target' and value not between '900' and '3600'"));
            consultas.Add(new Consulta("sga target",
                                            "entry.80853489",
                                            "select count(1) from gv$parameter where name = 'sga_target' and value <> '0'"));
            consultas.Add(new Consulta("sga maxsize",
                                            "entry.25361819",
                                            "select count(1) from gv$parameter where name = 'sga_max_size' and value < '1610612736'"));
            consultas.Add(new Consulta("rman backup archive",
                                                    "entry.2027155929",
                                                    "select count(1) from (select INPUT_TYPE, STATUS, max(START_TIME) start_time, max(END_TIME) end_time from V$RMAN_BACKUP_JOB_DETAILS where INPUT_TYPE = 'ARCHIVELOG' group by INPUT_TYPE, STATUS) where end_time < sysdate-3/24"));
            consultas.Add(new Consulta("rman backup full",
                                                "entry.1352456540",
                                                "select count(1) from (select INPUT_TYPE, STATUS, max(START_TIME) start_time, max(END_TIME) end_time from V$RMAN_BACKUP_JOB_DETAILS where INPUT_TYPE = 'DB FULL' group by INPUT_TYPE, STATUS) where end_time < sysdate-25/24"));
            consultas.Add(new Consulta("analise ultimos 10 dias",
                                                        "entry.1571854349",
                                                        "select count(1) from (select owner, max(nvl(last_analyzed,sysdate-100)) ultima_analise from dba_tables where owner not in('SH','PM','OE','IX','HR','SPATIAL_WFS_ADMIN_USR','SPATIAL_CSW_ADMIN_USR' ,'APEX_PUBLIC_USER' ,'DIP' ,'MDDATA' ,'XS$NULL' ,'ORACLE_OCM' ,'SCOTT' ,'DBSNMP' ,'SYSMAN' ,'OLAPSYS' ,'SI_INFORMTN_SCHEMA' ,'OWBSYS' ,'ORDPLUGINS' ,'XDB' ,'ANONYMOUS' ,'CTXSYS' ,'ORDDATA' ,'OWBSYS_AUDIT' ,'APEX_030200' ,'APPQOSSYS' ,'WMSYS' ,'EXFSYS' ,'ORDSYS' ,'MDSYS' ,'FLOWS_FILES' ,'SYSTEM' ,'SYS' ,'MGMT_VIEW' ,'OUTLN') group by owner order by 1,2) where ultima_analise < sysdate-10"));
            consultas.Add(new Consulta("tamanho membros",
                                                "entry.628707534",
                                                "select count(1) from gv$log where bytes < '209715200'"));
            consultas.Add(new Consulta("membros por grupo",
                                                    "entry.1618724961",
                                                    "select count(1) from (select INST_ID,GROUP#,MEMBERS membros from gv$log) where membros <2"));
            consultas.Add(new Consulta("grupos por instancia",
                                                        "entry.518231871",
                                                        "select count(1) from (select INST_ID,count(GROUP#) grupos from gv$log group by INST_ID) where grupos < 5"));
            consultas.Add(new Consulta("control files multiplexado",
                                                            "entry.2075443084",
                                                            "select count(1) from (select inst_id,count(*) multiplex from gv$controlfile group by inst_id) where multiplex < 3"));
        }

        public int getError(String query)
        {
            //Connect();
            OracleCommand cmd;
            OracleDataReader reader;
            int erros = 0;

            if(connection.State == System.Data.ConnectionState.Open)
            using (connection)
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Type tp = reader.GetFieldType(0);
                        erros = Decimal.ToInt32(reader.GetDecimal(0));
                    }
                }
            }
            return erros;
        }

    }
}
