using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "CarStatusType",
                columns: table => new
                {
                    StateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatusType", x => x.StateID);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractType = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractID);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    DiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountRatio = table.Column<decimal>(type: "decimal(3,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.DiscountID);
                });

            migrationBuilder.CreateTable(
                name: "DriverLicenses",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassExplanation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicenses", x => x.ClassID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    BloodType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Education = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ReportsToID = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<byte[]>(type: "image", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ReportsToID",
                        column: x => x.ReportsToID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    FuelTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.FuelTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Gears",
                columns: table => new
                {
                    GearID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GearType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gears", x => x.GearID);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    InsuranceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.InsuranceID);
                });

            migrationBuilder.CreateTable(
                name: "ReservationStatuses",
                columns: table => new
                {
                    ReservationStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStatuses", x => x.ReservationStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "BrandModelDetails",
                columns: table => new
                {
                    BrandModelDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandRefID = table.Column<int>(type: "int", nullable: false),
                    ModelYear = table.Column<DateTime>(type: "date", nullable: false),
                    Image = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandModelDetails", x => x.BrandModelDetailID);
                    table.ForeignKey(
                        name: "FK_BrandModelDetails_CarBrands_BrandRefID",
                        column: x => x.BrandRefID,
                        principalTable: "CarBrands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrandRefID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelID);
                    table.ForeignKey(
                        name: "FK_Models_CarBrands_BrandRefID",
                        column: x => x.BrandRefID,
                        principalTable: "CarBrands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    TCKNO = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Approval = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverID);
                    table.ForeignKey(
                        name: "FK_Drivers_DriverLicenses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "DriverLicenses",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationID);
                    table.ForeignKey(
                        name: "FK_Reservations_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationStatuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "ReservationStatuses",
                        principalColumn: "ReservationStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlateNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ChassisNo = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    GearID = table.Column<int>(type: "int", nullable: false),
                    BrandModelDetailID = table.Column<int>(type: "int", nullable: false),
                    FuelTypeID = table.Column<int>(type: "int", nullable: false),
                    DailyFee = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_Cars_BrandModelDetails_BrandModelDetailID",
                        column: x => x.BrandModelDetailID,
                        principalTable: "BrandModelDetails",
                        principalColumn: "BrandModelDetailID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeID",
                        column: x => x.FuelTypeID,
                        principalTable: "FuelTypes",
                        principalColumn: "FuelTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Gears_GearID",
                        column: x => x.GearID,
                        principalTable: "Gears",
                        principalColumn: "GearID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarHistories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    InspectionDate = table.Column<DateTime>(type: "date", nullable: false),
                    VisaDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarHistories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarHistories_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarStatuses",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    DateofEntry = table.Column<DateTime>(type: "Date", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatuses", x => new { x.CarID, x.StatusID });
                    table.ForeignKey(
                        name: "FK_CarStatuses_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarStatuses_CarStatusType_StatusID",
                        column: x => x.StatusID,
                        principalTable: "CarStatusType",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationDetails",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    DailyFee = table.Column<decimal>(type: "money", nullable: false),
                    DayCount = table.Column<short>(type: "smallint", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiscountID = table.Column<int>(type: "int", nullable: false),
                    DeliveryLocation = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ReturnLocation = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    InsuranceID = table.Column<int>(type: "int", nullable: false),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    ContractID = table.Column<int>(type: "int", nullable: false),
                    DeliveryEmployeeID = table.Column<int>(type: "int", nullable: true),
                    ReturnEmployeelID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDetails", x => new { x.CarID, x.ReservationID });
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Contracts_ContractID",
                        column: x => x.ContractID,
                        principalTable: "Contracts",
                        principalColumn: "ContractID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Discounts_DiscountID",
                        column: x => x.DiscountID,
                        principalTable: "Discounts",
                        principalColumn: "DiscountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "DriverID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Insurances_InsuranceID",
                        column: x => x.InsuranceID,
                        principalTable: "Insurances",
                        principalColumn: "InsuranceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Reservations_ReservationID",
                        column: x => x.ReservationID,
                        principalTable: "Reservations",
                        principalColumn: "ReservationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[,]
                {
                    { 1, "Audi" },
                    { 2, "Ford" },
                    { 3, "Citroen" },
                    { 4, "Volvo" }
                });

            migrationBuilder.InsertData(
                table: "CarStatusType",
                columns: new[] { "StateID", "StatusDescription" },
                values: new object[,]
                {
                    { 1, "Satildi" },
                    { 2, "Serviste" },
                    { 3, "PerteCikti" },
                    { 4, "Aktif" }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "ContractID", "ContractType" },
                values: new object[,]
                {
                    { 8, null },
                    { 7, null },
                    { 6, null },
                    { 5, null },
                    { 9, null },
                    { 3, null },
                    { 2, null },
                    { 1, null },
                    { 4, null }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "DiscountID", "DiscountRatio" },
                values: new object[,]
                {
                    { 8, 0.5m },
                    { 7, 0.45m },
                    { 5, 0.3m },
                    { 6, 0.4m },
                    { 3, 0.2m },
                    { 2, 0.15m },
                    { 1, 0.1m },
                    { 4, 0.25m }
                });

            migrationBuilder.InsertData(
                table: "DriverLicenses",
                columns: new[] { "ClassID", "ClassExplanation" },
                values: new object[,]
                {
                    { 11, "D" },
                    { 17, "M" },
                    { 16, "G" },
                    { 15, "F" },
                    { 14, "DE" },
                    { 13, "D1E" },
                    { 12, "D1" },
                    { 10, "CE" },
                    { 6, "BE" },
                    { 8, "C1" },
                    { 7, "C" },
                    { 5, "B1" },
                    { 4, "B" },
                    { 3, "A2" },
                    { 2, "A1" },
                    { 1, "A" },
                    { 9, "C1E" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "BirthDate", "BloodType", "Education", "Email", "FirstName", "Gender", "Image", "LastName", "Phone", "ReportsToID", "Summary" },
                values: new object[] { 1, "ÇANKAYA MH SOGUKSU CD NO 20/A Istanbul", new DateTime(1956, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(+)", "İstanbul Teknik Üniversitesi", "cengizilhan@gmail.com", "Cengiz", "M", null, "Ilhan", "05308563214", null, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "FuelTypeID", "Description", "FuelTypeName" },
                values: new object[,]
                {
                    { 1, "Benzinle Calisir", "Benzin" },
                    { 2, "Mazotla Calisir", "Dizel" },
                    { 3, "Gazla Calisir", "LPG" },
                    { 4, "Elektrik ve Benzinle Calisir", "Hibrit" }
                });

            migrationBuilder.InsertData(
                table: "Gears",
                columns: new[] { "GearID", "GearType" },
                values: new object[,]
                {
                    { 3, "Triptonik" },
                    { 1, "Duz" },
                    { 2, "Otomatik" }
                });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceID", "Description" },
                values: new object[,]
                {
                    { 1, "Standart : Dis hasar" },
                    { 2, "Premium : Dis hasar + iç hasar + hirsizlik" },
                    { 3, "Deluxe : Full teminat" }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatuses",
                columns: new[] { "ReservationStatusID", "Description" },
                values: new object[,]
                {
                    { 1, "Onaylandi" },
                    { 2, "Reddedildi" },
                    { 3, "Iptal" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "BirthDate", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Username" },
                values: new object[,]
                {
                    { 5, new DateTime(1979, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "osmankizil@gmail.com", "Osman", "Kizil", "343309830983098", "05422013784", true, "osmankizil21" },
                    { 1, new DateTime(1993, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "caglaroksuzuglu@gmail.com", "Çaglar", "Öksüzoglu", "123456789123456", "05382013784", true, "caglar1" },
                    { 2, new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "murtazayukselen@gmail.com", "Murtaza", "Yükselen", "232023229282093", "05322413789", true, "murtazayukselen" },
                    { 3, new DateTime(1990, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "alisimsek@gmail.com", "Ali", "Simsek", "123432098322309", "05422013784", true, "alisimsek" },
                    { 4, new DateTime(1972, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "sevinceryaman@gmail.com", "Sevinç", "Eryaman", "398309843048309", "05384013281", true, "sevincabla" },
                    { 6, new DateTime(1984, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "yaseminalbayrak@gmail.com", "Yasemin", "Albayrak", "304938092382309", "05332323784", true, "yaseminalb123" }
                });

            migrationBuilder.InsertData(
                table: "BrandModelDetails",
                columns: new[] { "BrandModelDetailID", "BrandRefID", "Image", "ModelYear" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 4, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 4, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 4, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 3, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 3, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 3, null, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 2, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 3, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverID", "Address", "Approval", "BirthDate", "ClassID", "Email", "FirstName", "LastName", "PhoneNumber", "TCKNO" },
                values: new object[,]
                {
                    { 7, "Eren apt. Daire 5 Suadiye Istanbul", true, new DateTime(1968, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "ahmetkarabulut@gmail.com", "Ahmet", "Karabulut", "05387051822", "82188634512" },
                    { 6, "ÇILEK SOKAK, NO.1 AKEL ISHANI KAT.3 D.63 ALTIYOL KADIKÖY,", true, new DateTime(1979, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "osmankizil@gmail.com", "Osman", "Kizil", "05397251837", "22188634593" },
                    { 9, "Beyoglu mah. Kizilcik sk. 15/5 Beyoglu", true, new DateTime(1975, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "hulyaerbudak@gmail.com", "Hülya", "Erbudak", "05337621835", "12188634573" },
                    { 4, "Baglarbasi mah. Aksu sk. 5/5 Üsküdar", true, new DateTime(1990, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "alisimsek@gmail.com", "Ali", "Simsek", "05357651038", "44188634559" },
                    { 3, "Eyüp sultan mah. Kaptan sok. No:22 Imam hatip lisesi cad.", true, new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "murtazayukselen@gmail.com", "Murtaza", "Yükselen", "05327151831", "72140634539" },
                    { 2, "Darülaeceze Cad. Perpa Ticaret Merkezi A Blok Kat:13 No:2041 Okmeydani", true, new DateTime(1993, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "caglaroksuzoglu@gmail.com", "Çaglar", "Öksüzoglu", "05327653882", "52188034576" },
                    { 1, "Cevizlik, Kartopu Sk. No:10, 34142 Bakirköy/Istanbul", true, new DateTime(1992, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "serdarer@gmail.com", "Serdar", "Er", "05327651832", "31188634536" },
                    { 8, "Bozkurt mah. Aksu sk. 2/5 Zeytinburnu", true, new DateTime(1980, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "mehmetsuna@gmail.com", "Mehmet", "Suna", "05387851889", "92188634522" },
                    { 5, "Eskisehir mah. Kurtulus cd. 4/221 Sisli", true, new DateTime(1972, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "sevinceryaman@gmail.com", "Sevinç", "Eryaman", "05387651839", "12188634567" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "BirthDate", "BloodType", "Education", "Email", "FirstName", "Gender", "Image", "LastName", "Phone", "ReportsToID", "Summary" },
                values: new object[,]
                {
                    { 2, "ÇANKAYA MH SOGUKSU CD NO 20/A Istanbul", new DateTime(1991, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRh(+)", "İstanbul Üniversitesi", "yelizbudak@gmail.com", "Yeliz", "F", null, "Budak", "05308563201", 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 3, "BAGLARBASI MH EDEN CD NO 2/b Istanbul", new DateTime(1985, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ABRh(+)", "Koç Üniversitesi", "serkanokat@gmail.com", "Serkan", "M", null, "Okat", "05308563202", 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 9, "Halil MH Dershane CD NO 3/5 Istanbul", new DateTime(1960, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(+)", "Oxford", "dursunusta@gmail.com", "Dursun", "M", null, "Candan", "05308563208", 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 4, "CENNET MH EVREN CD NO 14/5 Istanbul", new DateTime(1985, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(+)", "Ege Üniversitesi", "büyükosman@gmail.com", "Osman", "M", null, "Büyük", "05308563203", 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ModelID", "BrandRefID", "ModelName" },
                values: new object[,]
                {
                    { 16, 3, "C3 1.2 Feel AT" },
                    { 5, 1, "A4 Sedan 2.0 TFSI" },
                    { 4, 1, "A4 Sedan 2.0 TDI" },
                    { 3, 1, "A3 Sedan 1.0 TFSI" },
                    { 6, 2, "A4 Avant 1.4 Design" },
                    { 7, 2, "Fiesta 1.0 Titanium AT" },
                    { 8, 2, "Fiesta 1.5 TDCi Titanium" },
                    { 9, 2, "Focus 1.5 Titanium" },
                    { 10, 2, "Focus 1.5 Titanium AT" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ModelID", "BrandRefID", "ModelName" },
                values: new object[,]
                {
                    { 11, 2, "Focus 1.5 Trend X" },
                    { 12, 2, "Focus 1.5 Trend X AT" },
                    { 13, 2, "EcoSport 1.0 ST/Line AT" },
                    { 22, 4, "S60 1.5 T3 R-Design Plus" },
                    { 21, 4, "S60 1.5 T3 Premium" },
                    { 20, 4, "S60 1.5 T3 Advance" },
                    { 2, 1, "A3 Sportback 1.5 TFSI" },
                    { 1, 1, "A3 Sedan 1.5 TFSI" },
                    { 19, 3, "C3 Picasso 1.6 e-HDi Confort BMP6 STT" },
                    { 18, 3, "C3 Picasso 1.4 e-HDi Confort BMP STT" },
                    { 14, 3, "EcoSport 1.0 Syle AT" },
                    { 15, 3, "C3 1.2 Feel" },
                    { 17, 3, "C3 1.2 Shine AT" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BrandModelDetailID", "ChassisNo", "DailyFee", "FuelTypeID", "GearID", "PlateNo" },
                values: new object[,]
                {
                    { 1, 1, "BC83493824XDB45S2", 0m, 1, 1, "34KUC88" },
                    { 20, 20, "UJ86357681THC45Y1", 0m, 4, 1, "34NCN49" },
                    { 19, 19, "TE86357551DYY45Y1", 0m, 2, 3, "34MHR55" },
                    { 18, 18, "SU86357681ERD45Y1", 0m, 2, 3, "34NLM81" },
                    { 17, 17, "RI36557681UGR45S1", 0m, 4, 1, "34ALO39" },
                    { 16, 16, "PO86357681SRD45S1", 0m, 2, 3, "34NLM33" },
                    { 14, 14, "NL86357888SRD45S1", 0m, 4, 1, "34XPX11" },
                    { 13, 13, "MT86357814SRD45S1", 0m, 1, 2, "34APR17" },
                    { 12, 12, "LA86357814SRD45S1", 0m, 2, 2, "34RRT65" },
                    { 11, 11, "KK86753814SRD45S1", 0m, 4, 3, "34ZYT66" },
                    { 15, 15, "OT86357877SRD45S1", 0m, 2, 3, "34LMN18" },
                    { 9, 9, "IK86753814SRD45S1", 0m, 2, 1, "34TRM28" },
                    { 8, 8, "HC86793814BAW45S1", 0m, 1, 2, "34KSK34" },
                    { 7, 7, "GC83443814WAB45S1", 0m, 2, 1, "34BDR48" },
                    { 6, 6, "FC83483324DFB40S1", 0m, 1, 2, "33AKM31" },
                    { 5, 5, "EC83443814XAB45S1", 0m, 2, 1, "33AUC27" },
                    { 4, 4, "DC83493324DFB40S1", 0m, 1, 2, "34KRC50" },
                    { 3, 3, "CA83293824XDB41S2", 0m, 1, 1, "34ACC72" },
                    { 2, 2, "AC83493324DFB25S1", 0m, 3, 2, "34KTC91" },
                    { 10, 10, "JN86756814SRD45S1", 0m, 3, 1, "34MGL77" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "BirthDate", "BloodType", "Education", "Email", "FirstName", "Gender", "Image", "LastName", "Phone", "ReportsToID", "Summary" },
                values: new object[,]
                {
                    { 13, "Mali MH Erbil CD NO 10/5 Istanbul", new DateTime(1983, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(+)", "Yıldız Teknik Üniversitesi", "yelizyesilmen@gmail.com", "Yeliz", "F", null, "Yesilmen", "05308563212", 9, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 12, "Mumcu MH Gazi Mustafa Kemal CD NO 3/5 Istanbul", new DateTime(1991, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(+)", "Maltepe Teknik Üniversitesi", "elifuygur@gmail.com", "Elif", "F", null, "Uygur", "05308563211", 9, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 11, "Kennedy MH Halici CD NO 3/5 Istanbul", new DateTime(1991, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(-)", "İstanbul Teknik Üniversitesi", "esinkürek@gmail.com", "Esin", "F", null, "Kürek", "05308563210", 9, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 10, "Halil MH Dershane CD NO 3/5 Istanbul", new DateTime(1986, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0Rh(+)", "Bilkent Üniversitesi", "ekrempolat@gmail.com", "Ekrem", "M", null, "Polat", "05308563209", 9, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 5, "DURAK MH TERSHANE CD NO 8/5 Istanbul", new DateTime(1991, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0Rh(-)", "Bahçeşehir Üniversitesi", "serenserengiller@gmail.com", "Seren", "F", null, "Serengil", "05308563204", 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 7, "Atatürk MH Cumhuriyet CD NO 2/5 Istanbul", new DateTime(1991, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ABRh(+)", "Yeditepe Üniversitesi", "cerensal@gmail.com", "Melis", "F", null, "Sal", "05308563206", 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 6, "Bostan MH TALAT CD NO 2/5 Istanbul", new DateTime(1991, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(-)", "İstanbul Teknik Üniversitesi", "cenktasyurek.com", "Cenk", "M", null, "Tasyürek", "05308563205", 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 14, "Tatlises MH Türkü CD NO 45/5 Istanbul", new DateTime(1982, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(+)", "İzmir Ekonomi Üniversitesi", "denizakkaya@gmail.com", "Deniz", "F", null, "Akkaya", "05308563213", 9, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 8, "Karabulut MH Inönü CD NO 7/2 Istanbul", new DateTime(1992, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(+)", "İstanbul Teknik Üniversitesi", "handesüslü@gmail.com", "Hande", "F", null, "Süslü", "05308563207", 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" },
                    { 15, "Giresunlular MH Sirma CD NO 02/5 Istanbul", new DateTime(1985, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARh(+)", "Eskişehir Üniversitesi", "kuzeybati@gmail.com", "Kuzey", "M", null, "Bati", "05308563215", 9, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum" }
                });

            migrationBuilder.InsertData(
                table: "CarHistories",
                columns: new[] { "ID", "CarID", "InspectionDate", "VisaDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 11, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 15, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 16, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 14, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 17, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 18, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 13, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CarStatuses",
                columns: new[] { "CarID", "StatusID", "DateofEntry", "ReleaseDate" },
                values: new object[,]
                {
                    { 17, 2, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 4, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2017, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 4, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, new DateTime(2020, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 4, new DateTime(2018, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2020, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 4, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 4, new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(2020, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 4, new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationID", "EmployeeID", "ReservationDate", "StatusID", "UserID" },
                values: new object[,]
                {
                    { 3, 7, new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 1, 5, new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 5, 5, new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 2, 6, new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationID", "EmployeeID", "ReservationDate", "StatusID", "UserID" },
                values: new object[] { 6, 6, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationID", "EmployeeID", "ReservationDate", "StatusID", "UserID" },
                values: new object[] { 4, 8, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "CarID", "ReservationID", "ContractID", "DailyFee", "DayCount", "DeliveryDate", "DeliveryEmployeeID", "DeliveryLocation", "DiscountID", "DriverID", "InsuranceID", "ReturnDate", "ReturnEmployeelID", "ReturnLocation" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0000m, (short)3, new DateTime(2021, 4, 6, 9, 14, 5, 499, DateTimeKind.Local).AddTicks(4596), 10, "Baglarbasi cad Maltepe", 1, 1, 1, null, 14, "Baglarbasi cad Maltepe" },
                    { 5, 5, 5, 300.0000m, (short)6, new DateTime(2021, 4, 6, 9, 14, 5, 500, DateTimeKind.Local).AddTicks(1450), 10, "Atatürk Havalimani", 2, 5, 3, null, 11, "Atatürk Havalimani" },
                    { 6, 5, 6, 300.0000m, (short)6, new DateTime(2021, 4, 6, 9, 14, 5, 500, DateTimeKind.Local).AddTicks(1453), 12, "Atatürk Havalimani", 2, 6, 3, null, 13, "Atatürk Havalimani" },
                    { 7, 5, 7, 300.0000m, (short)6, new DateTime(2021, 4, 6, 9, 14, 5, 500, DateTimeKind.Local).AddTicks(1456), 14, "Atatürk Havalimani", 2, 7, 3, null, 10, "Atatürk Havalimani" },
                    { 2, 2, 2, 250.0000m, (short)5, new DateTime(2021, 4, 6, 9, 14, 5, 500, DateTimeKind.Local).AddTicks(1428), 11, "Eskisehir cad Kurtulus", 1, 2, 2, null, 12, "Eskisehir cad Kurtulus" },
                    { 8, 6, 8, 275.0000m, (short)1, new DateTime(2021, 4, 6, 9, 14, 5, 500, DateTimeKind.Local).AddTicks(1459), 10, "Gümüssuyu Taksim", 1, 8, 1, null, 14, "Gümüssuyu Taksim" },
                    { 9, 6, 9, 275.0000m, (short)1, new DateTime(2021, 4, 6, 9, 14, 5, 500, DateTimeKind.Local).AddTicks(1462), 11, "Gümüssuyu Taksim", 1, 9, 1, null, 12, "Gümüssuyu Taksim" },
                    { 3, 3, 3, 250.0000m, (short)7, new DateTime(2021, 4, 6, 9, 14, 5, 500, DateTimeKind.Local).AddTicks(1442), 13, "Adiyaman cad Bagcilar", 2, 3, 3, null, 11, "Eskisehir cad Kurtulus" },
                    { 4, 4, 4, 225.0000m, (short)7, new DateTime(2021, 4, 6, 9, 14, 5, 500, DateTimeKind.Local).AddTicks(1447), 12, "Esenler Otogar", 2, 4, 1, null, 10, "Sabiha Gökçen Kurtköy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandModelDetails_BrandRefID",
                table: "BrandModelDetails",
                column: "BrandRefID");

            migrationBuilder.CreateIndex(
                name: "IX_CarHistories_CarID",
                table: "CarHistories",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandModelDetailID",
                table: "Cars",
                column: "BrandModelDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeID",
                table: "Cars",
                column: "FuelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_GearID",
                table: "Cars",
                column: "GearID");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatuses_StatusID",
                table: "CarStatuses",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_ClassID",
                table: "Drivers",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsToID",
                table: "Employees",
                column: "ReportsToID");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandRefID",
                table: "Models",
                column: "BrandRefID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_ContractID",
                table: "ReservationDetails",
                column: "ContractID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_DiscountID",
                table: "ReservationDetails",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_DriverID",
                table: "ReservationDetails",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_InsuranceID",
                table: "ReservationDetails",
                column: "InsuranceID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_ReservationID",
                table: "ReservationDetails",
                column: "ReservationID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EmployeeID",
                table: "Reservations",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_StatusID",
                table: "Reservations",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserID",
                table: "Reservations",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarHistories");

            migrationBuilder.DropTable(
                name: "CarStatuses");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "ReservationDetails");

            migrationBuilder.DropTable(
                name: "CarStatusType");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "BrandModelDetails");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Gears");

            migrationBuilder.DropTable(
                name: "DriverLicenses");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ReservationStatuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CarBrands");
        }
    }
}
