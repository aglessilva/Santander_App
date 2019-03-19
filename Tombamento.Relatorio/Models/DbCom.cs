using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using Tombamento.Relatorio.FluentApi;

namespace Tombamento.Relatorio.Models
{
    public class DbCom: DbContext
    {
        public DbCom(): base("strCnn"){
          //  Database.SetInitializer(new DropCreateDatabaseAlways<DbCom>());
        }

        public DbSet<ColunaDivergente> ColunasDivergentes { get; set; }
        public DbSet<Finaceiro>Financeiros { get; set; }

        public DbSet<DivergenteParcela> DivergenciasParcelas { get; set; }
        public DbSet<Parcela> Parcelas { get; set; }
        
        public DbSet<DivergenciaOcorrencia> DivergenciasOcorrencias { get; set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }
 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FinanceiroFluentApi());
            modelBuilder.Configurations.Add(new ColunaDivergenteFluentApi());

            modelBuilder.Configurations.Add(new ParcelasFluentApi());
            modelBuilder.Configurations.Add(new ColunaDivergenteParcelasFluentApi());

            modelBuilder.Configurations.Add(new OcorrenciaFluentApi());
            modelBuilder.Configurations.Add(new DivergenciaOcorrenciaFluentApi());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
