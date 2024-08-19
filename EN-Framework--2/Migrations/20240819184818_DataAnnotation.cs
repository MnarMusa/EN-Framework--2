using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EN_Framework__2.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Studs",
                table: "Studs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_course_Insts",
                table: "course_Insts");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "course_Insts");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "Topic",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Studs",
                newName: "Stud_Course",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "course_Insts",
                newName: "Course_Inst",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "Course",
                newName: "C_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Topic",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                schema: "dbo",
                table: "Student",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                schema: "dbo",
                table: "Student",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                schema: "dbo",
                table: "Instructor",
                type: "Money",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Instructor",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Department",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Course",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Course_Id",
                schema: "dbo",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                schema: "dbo",
                table: "Stud_Course",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                schema: "dbo",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                schema: "dbo",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                schema: "dbo",
                table: "Course",
                column: "C_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                schema: "dbo",
                table: "Course_Inst",
                column: "Course_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                schema: "dbo",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                schema: "dbo",
                table: "Course_Inst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                schema: "dbo",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Topic",
                schema: "dbo",
                newName: "Topic");

            migrationBuilder.RenameTable(
                name: "Student",
                schema: "dbo",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                schema: "dbo",
                newName: "Studs");

            migrationBuilder.RenameTable(
                name: "Instructor",
                schema: "dbo",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Department",
                schema: "dbo",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Course_Inst",
                schema: "dbo",
                newName: "course_Insts");

            migrationBuilder.RenameTable(
                name: "Course",
                schema: "dbo",
                newName: "Courses");

            migrationBuilder.RenameColumn(
                name: "C_Id",
                table: "Courses",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topic",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Salary",
                table: "Instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Money");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Course_Id",
                table: "course_Insts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studs",
                table: "Studs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_course_Insts",
                table: "course_Insts",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");
        }
    }
}
