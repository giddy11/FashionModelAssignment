using FashionLine.DB.Mappings;
using FashionLine.Model;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB
{
    public class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        //SessionFactory initiates the connection between the model layer and the database layer

        public static ISessionFactory SessionFactory => _sessionFactory ??
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString
                (_connectionString))
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CustomerMap>())
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
            .BuildSessionFactory();

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        private static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\DataBasesLinks\FashionLineDB.mdf;Integrated Security=True;Connect Timeout=30";

    }
}
