using Autofac;
using Exam1.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Framework
{
    public class EntityModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public EntityModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentUnitofWork>().As<IStdentUnitofWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SUbjectRepository>().As<ISubjectRepository>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
