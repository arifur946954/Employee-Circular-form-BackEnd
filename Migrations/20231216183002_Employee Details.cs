using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreRelation.Migrations
{
    public partial class EmployeeDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permanentAddresses");

            migrationBuilder.DropTable(
                name: "presentAddress");

            migrationBuilder.DropTable(
                name: "customerAddresses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewDare = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppliedPost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedSelary = table.Column<int>(type: "int", nullable: false),
                    AppliedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "accademicQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accademicQualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_accademicQualifications_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employeeAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employeeAddresses_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "workExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_workExperiences_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "acQualifOnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccdmQlfId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acQualifOnes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_acQualifOnes_accademicQualifications_AccdmQlfId",
                        column: x => x.AccdmQlfId,
                        principalTable: "accademicQualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "acQualifThrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccdmQlfId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acQualifThrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_acQualifThrees_accademicQualifications_AccdmQlfId",
                        column: x => x.AccdmQlfId,
                        principalTable: "accademicQualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "acQualifTwos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccdmQlfId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acQualifTwos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_acQualifTwos_accademicQualifications_AccdmQlfId",
                        column: x => x.AccdmQlfId,
                        principalTable: "accademicQualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parmanentAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Village = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoliceStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parmanentAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_parmanentAddresses_employeeAddresses_EmployeeAddressId",
                        column: x => x.EmployeeAddressId,
                        principalTable: "employeeAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "presentAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Village = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoliceStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presentAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_presentAddresses_employeeAddresses_EmployeeAddressId",
                        column: x => x.EmployeeAddressId,
                        principalTable: "employeeAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "experienceFives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkExperienceId = table.Column<int>(type: "int", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experienceFives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_experienceFives_workExperiences_WorkExperienceId",
                        column: x => x.WorkExperienceId,
                        principalTable: "workExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "experienceFours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkExperienceId = table.Column<int>(type: "int", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experienceFours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_experienceFours_workExperiences_WorkExperienceId",
                        column: x => x.WorkExperienceId,
                        principalTable: "workExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "experienceOnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkExperienceId = table.Column<int>(type: "int", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experienceOnes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_experienceOnes_workExperiences_WorkExperienceId",
                        column: x => x.WorkExperienceId,
                        principalTable: "workExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "experienceThrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkExperienceId = table.Column<int>(type: "int", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experienceThrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_experienceThrees_workExperiences_WorkExperienceId",
                        column: x => x.WorkExperienceId,
                        principalTable: "workExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "experienceTwos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkExperienceId = table.Column<int>(type: "int", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experienceTwos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_experienceTwos_workExperiences_WorkExperienceId",
                        column: x => x.WorkExperienceId,
                        principalTable: "workExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accademicQualifications_EmployeeId",
                table: "accademicQualifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_acQualifOnes_AccdmQlfId",
                table: "acQualifOnes",
                column: "AccdmQlfId");

            migrationBuilder.CreateIndex(
                name: "IX_acQualifThrees_AccdmQlfId",
                table: "acQualifThrees",
                column: "AccdmQlfId");

            migrationBuilder.CreateIndex(
                name: "IX_acQualifTwos_AccdmQlfId",
                table: "acQualifTwos",
                column: "AccdmQlfId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeAddresses_EmployeeId",
                table: "employeeAddresses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_experienceFives_WorkExperienceId",
                table: "experienceFives",
                column: "WorkExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_experienceFours_WorkExperienceId",
                table: "experienceFours",
                column: "WorkExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_experienceOnes_WorkExperienceId",
                table: "experienceOnes",
                column: "WorkExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_experienceThrees_WorkExperienceId",
                table: "experienceThrees",
                column: "WorkExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_experienceTwos_WorkExperienceId",
                table: "experienceTwos",
                column: "WorkExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_parmanentAddresses_EmployeeAddressId",
                table: "parmanentAddresses",
                column: "EmployeeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_presentAddresses_EmployeeAddressId",
                table: "presentAddresses",
                column: "EmployeeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_workExperiences_EmployeeId",
                table: "workExperiences",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acQualifOnes");

            migrationBuilder.DropTable(
                name: "acQualifThrees");

            migrationBuilder.DropTable(
                name: "acQualifTwos");

            migrationBuilder.DropTable(
                name: "experienceFives");

            migrationBuilder.DropTable(
                name: "experienceFours");

            migrationBuilder.DropTable(
                name: "experienceOnes");

            migrationBuilder.DropTable(
                name: "experienceThrees");

            migrationBuilder.DropTable(
                name: "experienceTwos");

            migrationBuilder.DropTable(
                name: "parmanentAddresses");

            migrationBuilder.DropTable(
                name: "presentAddresses");

            migrationBuilder.DropTable(
                name: "accademicQualifications");

            migrationBuilder.DropTable(
                name: "workExperiences");

            migrationBuilder.DropTable(
                name: "employeeAddresses");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customerAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customerAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "permanentAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerAddressId = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thana = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permanentAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_permanentAddresses_customerAddresses_CustomerAddressId",
                        column: x => x.CustomerAddressId,
                        principalTable: "customerAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "presentAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerAddressId = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thana = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presentAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_presentAddress_customerAddresses_CustomerAddressId",
                        column: x => x.CustomerAddressId,
                        principalTable: "customerAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customerAddresses_CustomerId",
                table: "customerAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_permanentAddresses_CustomerAddressId",
                table: "permanentAddresses",
                column: "CustomerAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_presentAddress_CustomerAddressId",
                table: "presentAddress",
                column: "CustomerAddressId");
        }
    }
}
