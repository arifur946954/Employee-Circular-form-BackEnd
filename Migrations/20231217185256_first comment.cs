using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreRelation.Migrations
{
    public partial class firstcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "DefaultProduct",
                table: "workExperiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobLocation",
                table: "workExperiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Organization",
                table: "workExperiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "workExperiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReportingTo",
                table: "workExperiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Selary",
                table: "workExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "accademicQualifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Instution",
                table: "accademicQualifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "accademicQualifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PassingYear",
                table: "accademicQualifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Result",
                table: "accademicQualifications",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "accademicQualifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultProduct",
                table: "workExperiences");

            migrationBuilder.DropColumn(
                name: "JobLocation",
                table: "workExperiences");

            migrationBuilder.DropColumn(
                name: "Organization",
                table: "workExperiences");

            migrationBuilder.DropColumn(
                name: "Post",
                table: "workExperiences");

            migrationBuilder.DropColumn(
                name: "ReportingTo",
                table: "workExperiences");

            migrationBuilder.DropColumn(
                name: "Selary",
                table: "workExperiences");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "accademicQualifications");

            migrationBuilder.DropColumn(
                name: "Instution",
                table: "accademicQualifications");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "accademicQualifications");

            migrationBuilder.DropColumn(
                name: "PassingYear",
                table: "accademicQualifications");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "accademicQualifications");

            migrationBuilder.DropColumn(
                name: "University",
                table: "accademicQualifications");

            migrationBuilder.CreateTable(
                name: "acQualifOnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccdmQlfId = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    AccdmQlfId = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    AccdmQlfId = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "experienceFives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkExperienceId = table.Column<int>(type: "int", nullable: false),
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false)
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
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false)
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
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false)
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
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false)
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
                    DefaultProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selary = table.Column<int>(type: "int", nullable: false)
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
        }
    }
}
