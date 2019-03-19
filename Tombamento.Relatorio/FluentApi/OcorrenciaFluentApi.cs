using System.Data.Entity.ModelConfiguration;
using Tombamento.Relatorio.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tombamento.Relatorio.FluentApi
{
    public class OcorrenciaFluentApi : EntityTypeConfiguration<Ocorrencia>
    {
        public OcorrenciaFluentApi()
        {
            ToTable("TblOcorrencia");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(p => p.DivergenciasOcorrencia);
            HasIndex(p => p.C0);


            Property(p => p.C0).HasMaxLength(15);
            Property(p => p.C1).HasMaxLength(15);
            Property(p => p.C2).HasMaxLength(10);
            Property(p => p.C3).HasMaxLength(10);
            Property(p => p.C4).HasMaxLength(5);
            Property(p => p.C5).HasMaxLength(5);
            Property(p => p.C6).HasMaxLength(10);
            Property(p => p.C7).HasMaxLength(10);
            Property(p => p.C8).HasMaxLength(10);
            Property(p => p.C9).HasMaxLength(10);
            Property(p => p.C10).HasMaxLength(2);
            Property(p => p.C11).HasMaxLength(2);
            Property(p => p.C12).HasMaxLength(15);
            Property(p => p.C13).HasMaxLength(15);
            Property(p => p.C14).HasMaxLength(20);
            Property(p => p.C15).HasMaxLength(20);
            Property(p => p.C16).HasMaxLength(20);
            Property(p => p.C17).HasMaxLength(20);
            Property(p => p.C18).HasMaxLength(20);
            Property(p => p.C19).HasMaxLength(20);
            Property(p => p.C20).HasMaxLength(20);
            Property(p => p.C21).HasMaxLength(20);
            Property(p => p.C22).HasMaxLength(20);
            Property(p => p.C23).HasMaxLength(20);
            Property(p => p.C24).HasMaxLength(20);
            Property(p => p.C25).HasMaxLength(20);
            Property(p => p.C26).HasMaxLength(20);
            Property(p => p.C27).HasMaxLength(20);
            Property(p => p.C28).HasMaxLength(20);
            Property(p => p.C29).HasMaxLength(20);
            Property(p => p.C30).HasMaxLength(20);
            Property(p => p.C31).HasMaxLength(20);
            Property(p => p.C32).HasMaxLength(20);
            Property(p => p.C33).HasMaxLength(20);
            Property(p => p.C34).HasMaxLength(20);
            Property(p => p.C35).HasMaxLength(20);
            Property(p => p.C36).HasMaxLength(20);
            Property(p => p.C37).HasMaxLength(20);
            Property(p => p.C38).HasMaxLength(20);
            Property(p => p.C39).HasMaxLength(20);
            Property(p => p.C40).HasMaxLength(20);
            Property(p => p.C41).HasMaxLength(20);
            Property(p => p.C42).HasMaxLength(20);
            Property(p => p.C43).HasMaxLength(20);
            Property(p => p.C44).HasMaxLength(20);
            Property(p => p.C45).HasMaxLength(20);
            Property(p => p.C46).HasMaxLength(20);
            Property(p => p.C47).HasMaxLength(20);
            Property(p => p.C48).HasMaxLength(20);
            Property(p => p.C49).HasMaxLength(20);
            Property(p => p.C50).HasMaxLength(20);
            Property(p => p.C51).HasMaxLength(20);

        }
    }


    public class DivergenciaOcorrenciaFluentApi : EntityTypeConfiguration<DivergenciaOcorrencia>
    {
        public DivergenciaOcorrenciaFluentApi()
        {
            ToTable("TblColunaOcorrencia");
            HasKey(p => p.Id);
            HasIndex(p => p.Indice);
            HasIndex(p => p.Contrato);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Indice);
            Property(p => p.Contrato).HasMaxLength(20);
        }
    }
}
