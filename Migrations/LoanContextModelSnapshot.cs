﻿// <auto-generated />
using AcmeApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcmeApi.Migrations
{
    [DbContext(typeof(LoanContext))]
    partial class LoanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AcmeApi.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("applicantEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("applicantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("applicantPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("loanAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("loanId")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            applicantEmail = "JohnDoe@gmail.com",
                            applicantName = "John Doe",
                            applicantPhoneNumber = "000-867-5309",
                            loanAmount = "34,000.00",
                            loanId = "924e075f-4058-49fb-98f4-11283a1c2ad2"
                        },
                        new
                        {
                            Id = 2,
                            applicantEmail = "JaneDoe@gmail.com",
                            applicantName = "Jane Doe",
                            applicantPhoneNumber = "000-867-5310",
                            loanAmount = "80,000.00",
                            loanId = "0d7f34f6-f9ef-4077-b1f1-925a7a0bc884"
                        },
                        new
                        {
                            Id = 3,
                            applicantEmail = "JimmyDoe@gmail.com",
                            applicantName = "Jimmy Doe",
                            applicantPhoneNumber = "000-867-5311",
                            loanAmount = "200.00",
                            loanId = "71da68a7-c1e4-4497-9fb4-29b2bd8acfca"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
