using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{

   

    public abstract class Window : IWindow
    {
        public virtual string Title { get; set; }

        public virtual void Draw() {

        }
        public virtual void Draw(Point Params,int width, int height)
        {
            Rectangle rect = new Rectangle();
            rect.Height = height;
            rect.Width = width;
            rect.X = Params.X;
            rect.Y = Params.Y;
        }

        public Window()
        {
            
        }

        //you cannot declare a body cusit's mark as abstract
        //public abstract void Open() {
        //}

        public abstract void Open();

    }

    public class MessageWindow : Window
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public override void Draw(Point Params, int width, int height)
        {
            base.Draw(Params, width, height);

        }
    }

    public class ToolWindow : Window
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }
    }







    ///////////////////////////////////////////////// EXAMPLE ///////////////////// DBCONNECTION //////////////////////////
    //
    // Summary:
    //     Represents a connection to a database.


    public class MyqlConnection : DbConnection
    {
        public override string ConnectionString
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Database
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string DataSource
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string ServerVersion
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ConnectionState State
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }

        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        protected override DbCommand CreateDbCommand()
        {
            throw new NotImplementedException();
        }
    }







    public abstract class DbConnection : Component, IDbConnection, IDisposable
    {
        SqlConnection conn = new SqlConnection();
        MyqlConnection conn2 = new MyqlConnection();
        
        protected DbConnection() { }


        public abstract string ConnectionString { get; set; }

        public virtual int ConnectionTimeout { get; }

        public abstract string Database { get; }
        public abstract string DataSource { get; }
        public abstract string ServerVersion { get; }
        public abstract ConnectionState State { get; }
        protected virtual DbProviderFactory DbProviderFactory { get; }
        public event StateChangeEventHandler StateChange;


        public DbTransaction BeginTransaction()
        {
            return conn.BeginTransaction();
            //throw new NotImplementedException();
        }

        public DbTransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            //this is the real abstraction
            return conn2.BeginTransaction();
        }

        public abstract void ChangeDatabase(string databaseName);

        public abstract void Close();

        public DbCommand CreateCommand()
        {
            return conn.CreateCommand();
        }

        public virtual DataTable GetSchema()
        {
            return new DataTable();
        }

        public virtual DataTable GetSchema(string collectionName)
        {
            using (DataTable dt = new DataTable())
            {
                dt.TableName = collectionName;
                return dt;
            }
        }

        public virtual DataTable GetSchema(string collectionName, string[] restrictionValues)
        {
            using (DataTable dt = new DataTable())
            {
                dt.TableName = collectionName;
                return dt;
            }
        }

        public abstract void Open();

        protected abstract DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);
        protected abstract DbCommand CreateDbCommand();

        IDbTransaction IDbConnection.BeginTransaction()
        {
            throw new NotImplementedException();
        }

        IDbTransaction IDbConnection.BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        IDbCommand IDbConnection.CreateCommand()
        {
            throw new NotImplementedException();
        }
    }
}
