using System.Data.Entity.ModelConfiguration;
using Tombamento.Relatorio.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tombamento.Relatorio.FluentApi
{
    public class FinanceiroFluentApi : EntityTypeConfiguration<Finaceiro>
    {
        public FinanceiroFluentApi()
        {
            ToTable("TblFinanceiro");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(p => p.DivergenciaFinanceiro);
            HasIndex(p => p.C0);

            Property(p => p.C0).HasMaxLength(15);
            Property(p => p.C1).HasMaxLength(15);
            Property(p => p.C2).HasMaxLength(50);
            Property(p => p.C3).HasMaxLength(50);
            Property(p => p.C4).HasMaxLength(50);
            Property(p => p.C5).HasMaxLength(50);
            Property(p => p.C6).HasMaxLength(50);
            Property(p => p.C7).HasMaxLength(50);
            Property(p => p.C8).HasMaxLength(50);
            Property(p => p.C9).HasMaxLength(50);
            Property(p => p.C10).HasMaxLength(50);
            Property(p => p.C11).HasMaxLength(50);
            Property(p => p.C12).HasMaxLength(50);
            Property(p => p.C13).HasMaxLength(50);
            Property(p => p.C14).HasMaxLength(50);
            Property(p => p.C15).HasMaxLength(50);
            Property(p => p.C16).HasMaxLength(50);
            Property(p => p.C17).HasMaxLength(50);
            Property(p => p.C18).HasMaxLength(50);
            Property(p => p.C19).HasMaxLength(50);
            Property(p => p.C20).HasMaxLength(50);
            Property(p => p.C21).HasMaxLength(50);
            Property(p => p.C22).HasMaxLength(50);
            Property(p => p.C23).HasMaxLength(50);
            Property(p => p.C24).HasMaxLength(50);
            Property(p => p.C25).HasMaxLength(50);
            Property(p => p.C26).HasMaxLength(50);
            Property(p => p.C27).HasMaxLength(50);
            Property(p => p.C28).HasMaxLength(50);
            Property(p => p.C29).HasMaxLength(50);
            Property(p => p.C30).HasMaxLength(50);
            Property(p => p.C31).HasMaxLength(50);
            Property(p => p.C32).HasMaxLength(50);
            Property(p => p.C33).HasMaxLength(50);
            Property(p => p.C34).HasMaxLength(50);
            Property(p => p.C35).HasMaxLength(50);
            Property(p => p.C36).HasMaxLength(50);
            Property(p => p.C37).HasMaxLength(50);
            Property(p => p.C38).HasMaxLength(50);
            Property(p => p.C39).HasMaxLength(50);
            Property(p => p.C40).HasMaxLength(50);
            Property(p => p.C41).HasMaxLength(50);
            Property(p => p.C42).HasMaxLength(50);
            Property(p => p.C43).HasMaxLength(50);
            Property(p => p.C44).HasMaxLength(50);
            Property(p => p.C45).HasMaxLength(50);
            Property(p => p.C46).HasMaxLength(50);
            Property(p => p.C47).HasMaxLength(50);
            Property(p => p.C48).HasMaxLength(50);
            Property(p => p.C49).HasMaxLength(50);
            Property(p => p.C50).HasMaxLength(50);
            Property(p => p.C51).HasMaxLength(50);
            Property(p => p.C52).HasMaxLength(50);
            Property(p => p.C53).HasMaxLength(50);
            Property(p => p.C54).HasMaxLength(200);
            Property(p => p.C55).HasMaxLength(200);
            Property(p => p.C56).HasMaxLength(50);
            Property(p => p.C57).HasMaxLength(50);
            Property(p => p.C58).HasMaxLength(50);
            Property(p => p.C59).HasMaxLength(50);
            Property(p => p.C60).HasMaxLength(50);
            Property(p => p.C61).HasMaxLength(50);
            Property(p => p.C62).HasMaxLength(50);
            Property(p => p.C63).HasMaxLength(50);
            Property(p => p.C64).HasMaxLength(50);
            Property(p => p.C65).HasMaxLength(50);
            Property(p => p.C66).HasMaxLength(50);
            Property(p => p.C67).HasMaxLength(50);
            Property(p => p.C68).HasMaxLength(50);
            Property(p => p.C69).HasMaxLength(50);
            Property(p => p.C70).HasMaxLength(50);
            Property(p => p.C71).HasMaxLength(50);
            Property(p => p.C72).HasMaxLength(50);
            Property(p => p.C73).HasMaxLength(50);
            Property(p => p.C74).HasMaxLength(50);
            Property(p => p.C75).HasMaxLength(50);
            Property(p => p.C76).HasMaxLength(50);
            Property(p => p.C77).HasMaxLength(50);
            Property(p => p.C78).HasMaxLength(50);
            Property(p => p.C79).HasMaxLength(50);
            Property(p => p.C80).HasMaxLength(50);
            Property(p => p.C81).HasMaxLength(50);
            Property(p => p.C82).HasMaxLength(50);
            Property(p => p.C83).HasMaxLength(50);
            Property(p => p.C84).HasMaxLength(50);
            Property(p => p.C85).HasMaxLength(50);
            Property(p => p.C86).HasMaxLength(50);
            Property(p => p.C87).HasMaxLength(50);
            Property(p => p.C88).HasMaxLength(50);
            Property(p => p.C89).HasMaxLength(50);
            Property(p => p.C90).HasMaxLength(50);
            Property(p => p.C91).HasMaxLength(50);
            Property(p => p.C92).HasMaxLength(50);
            Property(p => p.C93).HasMaxLength(50);
            Property(p => p.C94).HasMaxLength(50);
            Property(p => p.C95).HasMaxLength(50);
            Property(p => p.C96).HasMaxLength(50);
            Property(p => p.C97).HasMaxLength(50);
            Property(p => p.C98).HasMaxLength(50);
            Property(p => p.C99).HasMaxLength(50);
            Property(p => p.C100).HasMaxLength(50);
            Property(p => p.C101).HasMaxLength(50);
            Property(p => p.C102).HasMaxLength(150);
            Property(p => p.C103).HasMaxLength(150);
            Property(p => p.C104).HasMaxLength(50);
            Property(p => p.C105).HasMaxLength(50);
            Property(p => p.C106).HasMaxLength(3);
            Property(p => p.C107).HasMaxLength(3);


        }

    }


    public class ColunaDivergenteFluentApi : EntityTypeConfiguration<ColunaDivergente>
    {
        public ColunaDivergenteFluentApi()
        {
            ToTable("TblColuna");
            HasKey(p => p.Id);
            HasIndex(p => p.Indice);
            HasIndex(p => p.Contrato);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p =>p.Indice);
            Property(p => p.Contrato).HasMaxLength(20);
        }
    }
}
