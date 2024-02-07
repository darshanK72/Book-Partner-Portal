﻿// <auto-generated />
using System;
using Book_Portal_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Book_Portal_API.Migrations
{
    [DbContext(typeof(PubsContext))]
    [Migration("20240207100720_newinit")]
    partial class newinit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Book_Portal_API.Models.Author", b =>
                {
                    b.Property<string>("AuId")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("au_id");

                    b.Property<string>("Address")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("address");

                    b.Property<string>("AuFname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("au_fname");

                    b.Property<string>("AuLname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("au_lname");

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<bool>("Contract")
                        .HasColumnType("bit")
                        .HasColumnName("contract");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("phone")
                        .HasDefaultValueSql("('UNKNOWN')")
                        .IsFixedLength();

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength();

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("zip")
                        .IsFixedLength();

                    b.HasKey("AuId")
                        .HasName("UPKCL_auidind");

                    b.HasIndex(new[] { "AuLname", "AuFname" }, "aunmind");

                    b.ToTable("authors", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Discount", b =>
                {
                    b.Property<decimal>("Discount1")
                        .HasMaxLength(5)
                        .HasColumnType("decimal(4, 2)")
                        .HasColumnName("discount");

                    b.Property<string>("Discounttype")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("discounttype");

                    b.Property<short?>("Highqty")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("smallint")
                        .HasColumnName("highqty");

                    b.Property<short?>("Lowqty")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("smallint")
                        .HasColumnName("lowqty");

                    b.Property<string>("StorId")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("stor_id")
                        .IsFixedLength();

                    b.HasIndex("StorId");

                    b.ToTable("discounts", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Employee", b =>
                {
                    b.Property<string>("EmpId")
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("char(9)")
                        .HasColumnName("emp_id")
                        .IsFixedLength();

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("fname");

                    b.Property<DateTime>("HireDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("hire_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<short>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("smallint")
                        .HasColumnName("job_id")
                        .HasDefaultValueSql("((1))");

                    b.Property<byte?>("JobLvl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .HasColumnType("tinyint")
                        .HasColumnName("job_lvl")
                        .HasDefaultValueSql("((10))");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("lname");

                    b.Property<string>("Minit")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("minit")
                        .IsFixedLength();

                    b.Property<string>("PubId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .HasDefaultValueSql("('9952')")
                        .IsFixedLength();

                    b.HasKey("EmpId")
                        .HasName("PK_emp_id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("EmpId"), false);

                    b.HasIndex("JobId");

                    b.HasIndex("PubId");

                    b.HasIndex(new[] { "Lname", "Fname", "Minit" }, "employee_ind");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex(new[] { "Lname", "Fname", "Minit" }, "employee_ind"));

                    b.ToTable("employee", null, t =>
                        {
                            t.HasTrigger("employee_insupd");
                        });

                    b.HasAnnotation("SqlServer:UseSqlOutputClause", false);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Job", b =>
                {
                    b.Property<short>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("smallint")
                        .HasColumnName("job_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("JobId"));

                    b.Property<string>("JobDesc")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("job_desc")
                        .HasDefaultValueSql("('New Position - title not formalized yet')");

                    b.Property<byte>("MaxLvl")
                        .HasMaxLength(1)
                        .HasColumnType("tinyint")
                        .HasColumnName("max_lvl");

                    b.Property<byte>("MinLvl")
                        .HasMaxLength(1)
                        .HasColumnType("tinyint")
                        .HasColumnName("min_lvl");

                    b.HasKey("JobId")
                        .HasName("PK__jobs__6E32B6A57BC9FAF6");

                    b.ToTable("jobs", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.PubInfo", b =>
                {
                    b.Property<string>("PubId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .IsFixedLength();

                    b.Property<byte[]>("Logo")
                        .HasColumnType("image")
                        .HasColumnName("logo");

                    b.Property<string>("PrInfo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("pr_info");

                    b.HasKey("PubId")
                        .HasName("UPKCL_pubinfo");

                    b.ToTable("pub_info", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Publisher", b =>
                {
                    b.Property<string>("PubId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .IsFixedLength();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("country")
                        .HasDefaultValueSql("('USA')");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PubName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("pub_name");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength();

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PubId")
                        .HasName("UPKCL_pubind");

                    b.ToTable("publishers", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Roysched", b =>
                {
                    b.Property<int?>("Hirange")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("hirange");

                    b.Property<int?>("Lorange")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("lorange");

                    b.Property<int?>("Royalty")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("royalty");

                    b.Property<string>("TitleId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("title_id");

                    b.HasIndex(new[] { "TitleId" }, "titleidind");

                    b.ToTable("roysched", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Sale", b =>
                {
                    b.Property<string>("StorId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("stor_id")
                        .IsFixedLength();

                    b.Property<string>("OrdNum")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ord_num");

                    b.Property<string>("TitleId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("title_id");

                    b.Property<DateTime>("OrdDate")
                        .HasColumnType("datetime")
                        .HasColumnName("ord_date");

                    b.Property<string>("Payterms")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("payterms");

                    b.Property<short>("Qty")
                        .HasColumnType("smallint")
                        .HasColumnName("qty");

                    b.HasKey("StorId", "OrdNum", "TitleId")
                        .HasName("UPKCL_sales");

                    b.HasIndex(new[] { "TitleId" }, "titleidind");

                    b.ToTable("sales", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Store", b =>
                {
                    b.Property<string>("StorId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("stor_id")
                        .IsFixedLength();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength();

                    b.Property<string>("StorAddress")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("stor_address");

                    b.Property<string>("StorName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("stor_name");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("zip")
                        .IsFixedLength();

                    b.HasKey("StorId")
                        .HasName("UPK_storeid");

                    b.ToTable("stores", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Title", b =>
                {
                    b.Property<string>("TitleId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("title_id");

                    b.Property<decimal?>("Advance")
                        .HasColumnType("money")
                        .HasColumnName("advance");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("notes");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<string>("PubId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .IsFixedLength();

                    b.Property<DateTime>("Pubdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("pubdate")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("Royalty")
                        .HasColumnType("int")
                        .HasColumnName("royalty");

                    b.Property<string>("Title1")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("title");

                    b.Property<string>("Type")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("type")
                        .HasDefaultValueSql("('UNDECIDED')")
                        .IsFixedLength();

                    b.Property<int?>("YtdSales")
                        .HasColumnType("int")
                        .HasColumnName("ytd_sales");

                    b.HasKey("TitleId")
                        .HasName("UPKCL_titleidind");

                    b.HasIndex("PubId");

                    b.HasIndex(new[] { "Title1" }, "titleind");

                    b.ToTable("titles", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Titleauthor", b =>
                {
                    b.Property<string>("AuId")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("au_id");

                    b.Property<string>("TitleId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("title_id");

                    b.Property<byte?>("AuOrd")
                        .HasColumnType("tinyint")
                        .HasColumnName("au_ord");

                    b.Property<int?>("Royaltyper")
                        .HasColumnType("int")
                        .HasColumnName("royaltyper");

                    b.HasKey("AuId", "TitleId")
                        .HasName("UPKCL_taind");

                    b.HasIndex(new[] { "AuId" }, "auidind");

                    b.HasIndex(new[] { "TitleId" }, "titleidind");

                    b.ToTable("titleauthor", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Titleview", b =>
                {
                    b.Property<string>("AuLname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("au_lname");

                    b.Property<byte?>("AuOrd")
                        .HasColumnType("tinyint")
                        .HasColumnName("au_ord");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<string>("PubId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .IsFixedLength();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("title");

                    b.Property<int?>("YtdSales")
                        .HasColumnType("int")
                        .HasColumnName("ytd_sales");

                    b.ToTable((string)null);

                    b.ToView("titleview", (string)null);
                });

            modelBuilder.Entity("Book_Portal_API.Models.Discount", b =>
                {
                    b.HasOne("Book_Portal_API.Models.Store", "Stor")
                        .WithMany()
                        .HasForeignKey("StorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__discounts__stor___3C69FB99");

                    b.Navigation("Stor");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Employee", b =>
                {
                    b.HasOne("Book_Portal_API.Models.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK__employee__job_id__48CFD27E");

                    b.HasOne("Book_Portal_API.Models.Publisher", "Pub")
                        .WithMany("Employees")
                        .HasForeignKey("PubId")
                        .IsRequired()
                        .HasConstraintName("FK__employee__pub_id__4BAC3F29");

                    b.Navigation("Job");

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("Book_Portal_API.Models.PubInfo", b =>
                {
                    b.HasOne("Book_Portal_API.Models.Publisher", "Pub")
                        .WithOne("PubInfo")
                        .HasForeignKey("Book_Portal_API.Models.PubInfo", "PubId")
                        .IsRequired()
                        .HasConstraintName("FK__pub_info__pub_id__440B1D61");

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Roysched", b =>
                {
                    b.HasOne("Book_Portal_API.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .IsRequired()
                        .HasConstraintName("FK__roysched__title___3A81B327");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Sale", b =>
                {
                    b.HasOne("Book_Portal_API.Models.Store", "Stor")
                        .WithMany("Sales")
                        .HasForeignKey("StorId")
                        .IsRequired()
                        .HasConstraintName("FK__sales__stor_id__37A5467C");

                    b.HasOne("Book_Portal_API.Models.Title", "Title")
                        .WithMany("Sales")
                        .HasForeignKey("TitleId")
                        .IsRequired()
                        .HasConstraintName("FK__sales__title_id__38996AB5");

                    b.Navigation("Stor");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Title", b =>
                {
                    b.HasOne("Book_Portal_API.Models.Publisher", "Pub")
                        .WithMany("Titles")
                        .HasForeignKey("PubId")
                        .HasConstraintName("FK__titles__pub_id__2E1BDC42");

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Titleauthor", b =>
                {
                    b.HasOne("Book_Portal_API.Models.Author", "Au")
                        .WithMany("Titleauthors")
                        .HasForeignKey("AuId")
                        .IsRequired()
                        .HasConstraintName("FK__titleauth__au_id__31EC6D26");

                    b.HasOne("Book_Portal_API.Models.Title", "Title")
                        .WithMany("Titleauthors")
                        .HasForeignKey("TitleId")
                        .IsRequired()
                        .HasConstraintName("FK__titleauth__title__32E0915F");

                    b.Navigation("Au");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Author", b =>
                {
                    b.Navigation("Titleauthors");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Publisher", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("PubInfo");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Store", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Book_Portal_API.Models.Title", b =>
                {
                    b.Navigation("Sales");

                    b.Navigation("Titleauthors");
                });
#pragma warning restore 612, 618
        }
    }
}
