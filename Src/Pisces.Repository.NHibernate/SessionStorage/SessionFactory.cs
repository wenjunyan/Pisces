using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Pisces.Repository.NHibernate.SessionStorage
{
    public class SessionFactory
    {
        private static ISessionFactory _sessionFactory;

        private static void Init()
        {
            Assembly mappingAssembly = Assembly.ReflectionOnlyLoadFrom("Pisces.Repository.NHibernate.dll");
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                .ConnectionString(s => s.Server("PISCES")
                .Database("Pisces")
                .TrustedConnection())).Mappings(m => m.FluentMappings.AddFromAssembly(typeof(SessionFactory).Assembly))
                .BuildSessionFactory();
        }

        private static ISessionFactory GetSessionFactory()
        {
            if (_sessionFactory == null)
                Init();

            return _sessionFactory;
        }

        private static ISession GetNewSession()
        {
            return GetSessionFactory().OpenSession();
        }

        public static ISession GetCurrentSession()
        {
            //ISession currentSession = _sessionFactory.GetCurrentSession();
            ISession currentSession = GetNewSession();
            //if (currentSession == null)
            //{
            //    currentSession = GetNewSession();
            //}

            return currentSession;
        }
    }

}
