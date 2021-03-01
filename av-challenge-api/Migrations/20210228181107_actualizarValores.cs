using Microsoft.EntityFrameworkCore.Migrations;

namespace av_challenge_api.Migrations
{
    public partial class actualizarValores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 1,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 94, 49, 27, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 2,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 57, 32, 50, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 3,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210228L, 86, 14, -16, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 4,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210228L, 84, 67, -11, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 5,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210228L, 18, 17, 23, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 6,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210228L, 28, 96, 42, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 7,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210228L, 73, 61, -18, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 8,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 44, 22, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 9,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210228L, 61, 98, 2, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 10,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210228L, 65, 66, -11, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 11,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210228L, 85, 24, 54, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 12,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210228L, 92, 31, 14, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 13,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 76, 3, 53, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 14,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210228L, 83, 40, 12, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 15,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210228L, 82, 22, 47, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 16,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210228L, 37, 56, 24, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 17,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210228L, 70, 30, -8, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 18,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 66, 76, 39, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 19,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 38, 30, 17, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 20,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 78, 21, 0, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 21,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 48, 83, 33, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 22,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210228L, 77, 41, 37, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 23,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 64, 94, 46, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 24,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210228L, 20, 33, 30, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 25,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 59, 74, 30, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 26,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 44, 84, 24, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 27,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210228L, 94, 77, 8, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 28,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 7, 81, 5, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 29,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210228L, 30, 99, 8, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 30,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210228L, 1, 65, 22, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 31,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210301L, 14, 0, 50, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 32,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210301L, 62, 23, 52, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 33,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 4, 97, 49, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 34,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210301L, 66, 99, -12, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 35,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210301L, 97, 25, 43, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 36,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 56, 43, 30, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 37,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210301L, 54, 83, 50, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 38,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210301L, 9, 63, 7, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 39,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210301L, 88, 19, -13, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 40,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210301L, 40, 95, 9, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 41,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 62, 99, 22, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 42,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 91, 3, 31, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 43,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 19, 67, 20, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 44,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210301L, 0, 43, -14, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 45,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210301L, 32, 90, 16, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 46,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 48, 37, 29, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 47,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210301L, 35, 3, 34, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 48,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 77, 20, 50, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 49,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210301L, 46, 71, 5, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 50,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210301L, 57, 0, 11, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 51,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 1, 94, 52, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 52,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210301L, 23, 67, 29, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 53,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210301L, 18, 54, 2, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 54,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 6, 32, 17, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 55,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210301L, 79, 66, 46, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 56,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210301L, 93, 43, 37, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 57,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 79, 80, 29, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 58,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210301L, 59, 1, 38, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 59,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Lluvioso", 20210301L, 3, 96, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 60,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210301L, 64, 52, 39, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 61,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 59, 93, -13, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 62,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210302L, 45, 14, 2, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 63,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 32, 73, -4, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 64,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210302L, 85, 74, 17, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 65,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 75, 73, 16, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 66,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210302L, 76, 62, 48, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 67,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 79, -2, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 68,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 96, 20, 34, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 69,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210302L, 95, 55, 27, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 70,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210302L, 92, 64, 20, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 71,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210302L, 67, 66, -17, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 72,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 27, 18, 7, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 73,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210302L, 43, 38, 31, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 74,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210302L, 37, 94, 12, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 75,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210302L, 5, 78, 1, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 76,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210302L, 50, 77, 49, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 77,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210302L, 23, 70, 0, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 78,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210302L, 10, 10, 23, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 79,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Soleado", 20210302L, 70, 93, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 80,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210302L, 63, 12, -2, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 81,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 31, 26, 24, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 82,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 24, 61, -1, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 83,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210302L, 39, 67, 24, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 84,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210302L, 43, 14, 53, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 85,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210302L, 91, 83, 5, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 86,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 85, 8, 6, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 87,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210302L, 6, 14, 39, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 88,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210302L, 50, 38, 54, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 89,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210302L, 25, 85, 52, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 90,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210302L, 48, 54, 44, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 91,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210303L, 59, 68, -13, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 92,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210303L, 86, 35, 37, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 93,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210303L, 67, 75, -7, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 94,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210303L, 50, 60, 13, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 95,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210303L, 18, 64, 25, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 96,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210303L, 2, 58, 15, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 97,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210303L, 0, 59, 40, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 98,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210303L, 85, 55, -12, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 99,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210303L, 1, 51, 28, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 100,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 98, 18, -4, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 101,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210303L, 71, 3, -1, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 102,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 57, 50, 14, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 103,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210303L, 98, 33, -7, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 104,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210303L, 96, 74, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 105,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210303L, 28, 74, 46, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 106,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 30, 63, -14, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 107,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 88, 60, 1, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 108,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 50, 88, 37, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 109,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210303L, 89, 98, 25, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 110,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210303L, 90, 53, 3, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 111,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 19, 22, 15, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 112,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 62, 75, 18, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 113,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210303L, 39, 19, 41, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 114,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210303L, 21, 44, 23, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 115,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 52, 24, 32, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 116,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210303L, 25, 85, 48, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 117,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210303L, 1, 72, 21, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 118,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210303L, 40, 40, -15, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 119,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210303L, 69, 25, -19, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 120,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210303L, 97, 58, 11, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 121,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210304L, 91, 32, 45 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 122,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210304L, 44, 69, -3, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 123,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210304L, 4, 49, 29, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 124,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 49, 18, -14, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 125,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 67, 3, -7, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 126,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210304L, 27, 55, 13, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 127,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210304L, 12, 87, 4, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 128,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210304L, 51, 81, -3, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 129,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 96, 96, 8, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 130,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210304L, 26, 20, 19, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 131,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 61, 9, -3, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 132,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210304L, 54, 64, 42, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 133,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 89, 41, 31, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 134,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210304L, 39, 37, 38, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 135,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210304L, 16, 66, 0, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 136,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210304L, 45, 6, -5, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 137,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210304L, 65, 29, -3, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 138,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210304L, 82, 26, -3, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 139,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210304L, 81, 27, 23, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 140,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210304L, 6, 52, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 141,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 33, 81, -9, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 142,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210304L, 56, 92, 22, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 143,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 10, 19, 38, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 144,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 47, 75, 9, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 145,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 48, 54, 18, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 146,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210304L, 97, 85, -20, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 147,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210304L, 23, 91, -9, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 148,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 44, 95, 11, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 149,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Soleado", 20210304L, 96, 69, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 150,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210304L, 37, 16, 9, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 151,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210305L, 72, 58, -5, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 152,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210305L, 8, 33, 25, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 153,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 16, 95, 33, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 154,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 84, 95, 44, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 155,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 90, 30, 13, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 156,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 12, 58, 41, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 157,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 68, 47, 43, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 158,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210305L, 78, 22, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 159,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210305L, 6, 86, -14, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 160,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210305L, 60, 53, 6, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 161,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210305L, 5, 31, 12, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 162,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210305L, 13, 67, 47, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 163,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210305L, 72, 20, -19, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 164,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210305L, 0, 26, -2, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 165,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 22, 16, 31, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 166,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210305L, 16, 23, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 167,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210305L, 15, 98, 1, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 168,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 88, 41, 19, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 169,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 79, 5, 46, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 170,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210305L, 12, 14, 45, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 171,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 51, 52, -14, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 172,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210305L, 24, 9, 0, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 173,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210305L, 63, 51, 29, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 174,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 39, 5, -17, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 175,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210305L, 65, 38, 41, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 176,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210305L, 42, 36, 27, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 177,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210305L, 41, 10, 12, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 178,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210305L, 0, 46, 37 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 179,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210305L, 48, 17, 12, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 180,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210305L, 92, 41, 7, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 181,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210306L, 19, 74, 41, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 182,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210306L, 79, 87, 32, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 183,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Soleado", 20210306L, 91, 67, 47 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 184,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210306L, 1, 10, 21, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 185,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210306L, 41, 4, 22, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 186,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210306L, 51, 89, 28, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 187,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210306L, 16, 44, -4, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 188,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210306L, 12, 91, 31, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 189,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210306L, 80, 67, 46, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 190,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210306L, 61, 26, 37, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 191,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210306L, 7, 39, -1, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 192,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210306L, 99, 33, 37, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 193,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210306L, 79, 35, 40, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 194,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210306L, 4, 51, 14, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 195,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210306L, 42, 98, 28, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 196,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210306L, 15, 23, 47, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 197,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210306L, 17, 27, 8, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 198,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210306L, 66, 36, 41, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 199,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210306L, 85, 91, 6, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 200,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210306L, 18, 88, 20, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 201,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210306L, 46, 21, -2, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 202,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210306L, 55, 97, 1, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 203,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210306L, 63, 18, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 204,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210306L, 93, 18, 19, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 205,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210306L, 4, 84, -14, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 206,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210306L, 22, 12, 34, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 207,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210306L, 39, 5, -19, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 208,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210306L, 92, 81, -8, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 209,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210306L, 4, 81, 43, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 210,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210306L, 85, 28, -7, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 211,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210307L, 86, 94, 6, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 212,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 24, 17, 10, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 213,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 55, 74, -9, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 214,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 64, 79, 15, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 215,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 59, 25, 33, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 216,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210307L, 2, 80, 0, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 217,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 4, 27, 13, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 218,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210307L, 31, 19, -15, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 219,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 41, 57, 54, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 220,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 75, 25, -13, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 221,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210307L, 86, 63, 8, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 222,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210307L, 56, 35, -13, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 223,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210307L, 43, 15, 25, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 224,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 53, 70, 46, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 225,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 94, 47, 0, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 226,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210307L, 2, 83, -10, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 227,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210307L, 96, 4, -19, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 228,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 69, 40, 40, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 229,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210307L, 7, 63, 33, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 230,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 46, 14, 42, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 231,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210307L, 45, 71, 9, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 232,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210307L, 48, 69, 48, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 233,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210307L, 13, 33, -1, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 234,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210307L, 55, 19, 21, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 235,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210307L, 79, 1, 16, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 236,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210307L, 26, 40, 28, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 237,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210307L, 78, 36, -20, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 238,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210307L, 80, 59, 2, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 239,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210307L, 19, 92, -12, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 240,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210307L, 57, 49, 8, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 241,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210308L, 69, 58, 28, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 242,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210308L, 3, 92, 8, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 243,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210308L, 9, 42, 17, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 244,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210308L, 68, 54, 47, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 245,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210308L, 33, 38, 52, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 246,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Soleado", 20210308L, 18, 81, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 247,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210308L, 57, 82, -10, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 248,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210308L, 6, 67, 10, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 249,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210308L, 82, 56, 8, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 250,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210308L, 70, 82, 31, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 251,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210308L, 42, 81, 42, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 252,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210308L, 18, 25, -1, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 253,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210308L, 22, 73, 22, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 254,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210308L, 16, 85, 30, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 255,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210308L, 72, 48, -4, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 256,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210308L, 13, 56, 10, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 257,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210308L, 70, 10, 34, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 258,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210308L, 58, 40, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 259,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210308L, 75, 49, -9, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 260,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210308L, 63, 33, 28, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 261,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210308L, 59, 66, 42, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 262,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210308L, 23, 8, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 263,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210308L, 43, 11, 32, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 264,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210308L, 14, 3, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 265,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210308L, 70, 27, 0, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 266,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210308L, 71, 72, 34, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 267,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210308L, 80, 92, -16, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 268,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210308L, 93, 51, -15, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 269,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210308L, 90, 16, -2, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 270,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210308L, 16, 5, -17, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 271,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210309L, 40, 18, 25, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 272,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210309L, 59, 95, 22, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 273,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210309L, 43, 37, 27, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 274,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210309L, 77, 31, 37, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 275,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210309L, 57, 9, 51, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 276,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210309L, 34, 36, -12, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 277,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210309L, 89, 55, 30, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 278,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Caluroso", 20210309L, 2, 52, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 279,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210309L, 73, 91, -12, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 280,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210309L, 90, 73, 45, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 281,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210309L, 45, 27, 34, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 282,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210309L, 77, 60, 18, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 283,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210309L, 1, 61, -6, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 284,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210309L, 56, 47, -14, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 285,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210309L, 92, 29, -3, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 286,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210309L, 79, 35, -18, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 287,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210309L, 99, 45, 8, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 288,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210309L, 21, 9, 9, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 289,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210309L, 53, 75, 0, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 290,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210309L, 4, 89, 17, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 291,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210309L, 97, 16, 9, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 292,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210309L, 7, 34, 12, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 293,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210309L, 10, 80, -9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 294,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210309L, 8, 62, 35, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 295,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210309L, 68, 25, 53, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 296,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210309L, 77, 75, 16, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 297,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210309L, 12, 31, -10, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 298,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210309L, 77, 48, -4, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 299,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210309L, 56, 2, -17, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 300,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210309L, 47, 64, 15, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 301,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210310L, 14, 81, 45, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 302,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210310L, 58, 48, -10, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 303,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210310L, 81, 57, 30, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 304,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210310L, 32, 68, 43, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 305,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210310L, 56, 85, -1, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 306,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 73, 69, 52, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 307,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210310L, 94, 28, 42, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 308,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210310L, 18, 16, 4, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 309,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210310L, 41, 89, 34, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 310,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210310L, 43, 20, 15, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 311,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210310L, 44, 31, 38, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 312,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210310L, 59, 24, -19, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 313,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210310L, 58, 74, 13, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 314,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 94, 62, 9, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 315,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 44, 49, 30, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 316,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210310L, 97, 43, 7, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 317,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210310L, 59, 25, 36, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 318,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210310L, 22, 83, 18, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 319,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 93, 57, -14, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 320,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 44, 30, 53, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 321,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210310L, 96, 26, 43, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 322,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210310L, 31, 87, 1, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 323,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210310L, 71, 26, 23, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 324,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210310L, 12, 14, -6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 325,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 19, 40, 22, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 326,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 50, 56, -13, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 327,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 48, 98, -16, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 328,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 93, 29, 16, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 329,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210310L, 86, 51, 28, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 330,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210310L, 88, 85, 41, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 331,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210311L, 7, 17, 42 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 332,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210311L, 12, 6, 13, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 333,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 63, 36, 34, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 334,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 11, 78, 24, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 335,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210311L, 53, 21, 46, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 336,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 21, 53, -17, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 337,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 75, 67, -2, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 338,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210311L, 55, 46, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 339,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210311L, 67, 17, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 340,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210311L, 89, 87, 1, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 341,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210311L, 20, 73, -18, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 342,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 2, 63, 26, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 343,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 33, 84, 48, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 344,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210311L, 22, 60, -17, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 345,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210311L, 22, 22, 31, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 346,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 70, 53, 34, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 347,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 94, 63, -8, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 348,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210311L, 68, 46, 18, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 349,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210311L, 55, 88, -2, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 350,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 99, 83, 23, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 351,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210311L, 47, 65, 30, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 352,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 44, 50, 40, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 353,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 55, 93, -14, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 354,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210311L, 99, 90, 0, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 355,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 17, 92, 23, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 356,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 1, 67, 40, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 357,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210311L, 38, 54, 46, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 358,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 49, 16, 18, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 359,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210311L, 88, 1, 54, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 360,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210311L, 18, 32, 3, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 361,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210312L, 85, 84, 30, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 362,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210312L, 97, 47, 36, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 363,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210312L, 69, 49, -11, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 364,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 62, 54, 21, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 365,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 40, 41, -12, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 366,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210312L, 78, 3, 22, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 367,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 31, 49, 16, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 368,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 7, 68, -18, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 369,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210312L, 61, 18, -18, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 370,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210312L, 78, 32, 17, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 371,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210312L, 77, 70, 37, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 372,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210312L, 46, 44, -1, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 373,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Caluroso", 20210312L, 30, 69, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 374,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210312L, 67, 18, 27, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 375,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210312L, 63, 46, 45, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 376,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210312L, 77, 79, 49, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 377,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210312L, 16, 25, -2, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 378,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210312L, 61, 72, 38, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 379,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210312L, 76, 21, 24, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 380,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210312L, 1, 87, 5, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 381,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210312L, 68, 64, 4, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 382,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210312L, 56, 6, 2, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 383,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 68, 66, 15, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 384,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210312L, 92, 52, 15, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 385,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 27, 56, 48, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 386,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210312L, 3, 70, 28, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 387,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 60, 77, -17, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 388,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 27, 56, 24, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 389,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210312L, 88, 15, 32, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 390,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210312L, 95, 52, 49, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 391,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210313L, 91, 95, 40, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 392,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210313L, 35, 37, 36, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 393,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210313L, 84, 3, 24, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 394,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210313L, 89, 6, 31, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 395,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210313L, 94, 25, 48, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 396,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210313L, 58, 68, 36 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 397,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210313L, 57, 75, -11, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 398,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 13, 86, -13, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 399,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Lluvioso", 20210313L, 51, 21, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 400,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210313L, 78, 31, 30, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 401,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210313L, 31, 63, 44, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 402,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 2, 0, 21, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 403,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210313L, 30, 78, -15, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 404,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210313L, 12, 45, 43, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 405,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 17, 92, 42, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 406,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 73, 73, 32, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 407,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 53, 90, 13, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 408,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 66, 43, 16, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 409,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210313L, 64, 83, -14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 410,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210313L, 97, 91, 12, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 411,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210313L, 50, 18, -4, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 412,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 8, 46, 50, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 413,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210313L, 74, 26, 41, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 414,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210313L, 84, 25, -8, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 415,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 50, 79, 10, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 416,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210313L, 76, 27, 54, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 417,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210313L, 16, 76, 38 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 418,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 4, 40, -1, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 419,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210313L, 6, 35, -18, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 420,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210313L, 48, 8, 42, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 421,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210314L, 78, 6, -7, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 422,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 49, 68, 11, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 423,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 20, 69, 29, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 424,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 24, 9, -16, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 425,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210314L, 16, 20, 37, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 426,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 29, 73, -16, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 427,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 79, 47, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 428,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 75, 97, 33, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 429,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 1, 91, 23, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 430,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210314L, 34, 14, 4, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 431,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210314L, 41, 84, 34, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 432,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210314L, 99, 89, 53, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 433,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 92, 38, 31, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 434,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 50, 48, 44, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 435,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210314L, 10, 34, -15, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 436,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 26, 19, 44, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 437,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 70, 39, 48, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 438,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 27, 38, -16, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 439,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 46, 98, 41, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 440,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 61, 98, -6, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 441,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210314L, 31, 64, 43, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 442,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 1, 74, 9, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 443,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210314L, 96, 62, 38, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 444,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 75, 67, 2, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 445,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210314L, 21, 21, 15, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 446,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 27, 87, -13, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 447,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 24, 57, 45, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 448,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 2, 7, -1, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 449,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210314L, 34, 37, 3, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 450,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210314L, 1, -6, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 451,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 12, 22, 18, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 452,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210315L, 1, 43, 27, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 453,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210315L, 59, 46, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 454,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210315L, 82, 37, -5, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 455,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210315L, 91, 65, -4, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 456,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210315L, 48, 86, -13, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 457,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 89, -15, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 458,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210315L, 3, 44, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 459,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210315L, 42, 6, 42, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 460,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210315L, 25, 77, 43, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 461,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 44, 19, 41, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 462,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 15, 31, 44, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 463,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210315L, 64, 94, 37, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 464,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210315L, 86, 60, 26, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 465,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 10, 33, 37, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 466,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210315L, 28, 22, -8, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 467,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210315L, 45, 60, 3, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 468,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 57, 45, 45, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 469,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210315L, 33, 28, 4, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 470,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 71, 42, 46, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 471,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210315L, 48, 90, -2, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 472,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 22, 8, 15, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 473,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210315L, 18, 2, 27, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 474,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 0, 49, -8, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 475,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210315L, 59, 2, -9, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 476,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 71, 0, 15, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 477,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210315L, 82, 51, 35, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 478,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210315L, 46, 12, 10, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 479,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210315L, 61, 23, 39, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 480,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210315L, 28, 10, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 481,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 6, 9, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 482,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 16, 31, -4, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 483,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210316L, 54, 36, 15, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 484,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Lluvioso", 20210316L, 60, 20, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 485,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 33, 2, -18, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 486,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 62, 41, 49, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 487,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 34, 71, 8, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 488,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 62, 45, 4, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 489,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 20, 96, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 490,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210316L, 6, 68, 11, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 491,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 64, 49, -13, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 492,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 99, 8, 7, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 493,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 66, 68, 39, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 494,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 25, 2, 36, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 495,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210316L, 24, 57, 30, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 496,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 14, 81, -15, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 497,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 20, 35, -3, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 498,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210316L, 57, 7, 45, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 499,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 91, 45, -2, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 500,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 36, 30, 10, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 501,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 55, 42, 9, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 502,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210316L, 18, 24, 18, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 503,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 3, 93, 21, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 504,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 86, 48, 13, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 505,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210316L, 31, 45, 30, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 506,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 19, 66, -5, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 507,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210316L, 7, 45, 37, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 508,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210316L, 2, 79, 40, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 509,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210316L, 30, 89, 27, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 510,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210316L, 42, 2, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 511,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 85, 44, 49, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 512,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210317L, 71, 11, 50, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 513,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 12, 5, 43, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 514,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210317L, 42, 85, -13, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 515,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 9, 45, 29, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 516,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 64, 14, 39, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 517,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210317L, 21, 40, 38, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 518,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 24, 59, 4, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 519,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210317L, 83, 7, 32, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 520,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210317L, 12, 77, 23, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 521,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210317L, 28, 99, 13, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 522,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210317L, 14, 34, 15, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 523,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210317L, 99, 47, 39, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 524,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION" },
                values: new object[] { "Fresco", 20210317L, 99, 83 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 525,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 48, 61, 17, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 526,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210317L, 15, 61, 23, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 527,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210317L, 47, 2, -19, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 528,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 49, 12, 38, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 529,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210317L, 0, 45, 53, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 530,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210317L, 33, 8, -4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 531,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 10, 77, 35, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 532,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210317L, 1, 51, 42, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 533,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210317L, 39, 18, 44, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 534,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210317L, 28, 99, 38, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 535,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210317L, 16, 34, 4, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 536,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210317L, 43, 60, -17, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 537,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210317L, 26, 28, 17, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 538,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210317L, 48, 91, -2, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 539,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210317L, 33, 10, 0, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 540,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210317L, 80, 5, 39, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 541,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210318L, 7, 79, -3, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 542,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 77, 60, 9, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 543,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210318L, 67, 7, -4, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 544,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210318L, 14, 92, 22, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 545,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 10, 50, 44, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 546,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 2, 0, -4, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 547,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210318L, 24, 80, 54, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 548,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 62, 21, 33, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 549,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210318L, 69, 14, 27, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 550,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 52, 42, -6, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 551,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 87, 91, 45, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 552,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 21, 69, 34, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 553,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 27, 58, 9, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 554,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 48, 82, 10, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 555,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 7, 29, 7, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 556,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 37, 80, 33, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 557,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210318L, 9, 48, 39, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 558,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 68, 92, -14, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 559,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 98, 99, -19, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 560,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 31, 87, -16, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 561,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 82, 93, 7, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 562,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210318L, 84, 84, 23, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 563,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210318L, 55, 31, 48, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 564,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 2, 49, 47, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 565,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 58, 14, 16, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 566,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 94, 30, 7, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 567,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 12, 49, 43, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 568,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210318L, 65, 66, 44, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 569,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210318L, 9, 8, -2, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 570,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210318L, 13, 43, 32, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 571,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 45, 84, 22, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 572,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 50, 35, -4, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 573,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 30, 89, 0, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 574,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 67, 19, 11, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 575,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210319L, 66, 83, -3, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 576,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210319L, 26, 4, 9, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 577,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 96, 17, 49, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 578,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210319L, 24, 3, 54, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 579,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 69, 15, 18, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 580,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210319L, 44, 78, 5, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 581,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 71, 76, 17, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 582,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210319L, 56, 17, 34, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 583,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 66, 8, -8, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 584,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 36, 92, -13, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 585,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210319L, 7, 94, 9, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 586,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210319L, 84, 14, -15, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 587,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 67, 60, 26, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 588,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 28, 45, -8, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 589,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210319L, 52, 46, 40, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 590,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 50, 49, 11, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 591,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 16, 41, 11, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 592,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 50, 68, 21, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 593,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 36, 33, 23, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 594,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 85, 41, 22, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 595,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210319L, 79, 64, 28, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 596,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 38, 42, 49, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 597,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 61, 63, 23, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 598,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210319L, 82, 43, -5, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 599,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210319L, 37, 95, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 600,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210319L, 59, 10, 15, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 601,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210320L, 60, 63, -19, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 602,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210320L, 51, 61, 38, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 603,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210320L, 31, -11, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 604,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210320L, 75, 72, 50, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 605,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210320L, 58, -10, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 606,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210320L, 51, 27, 31, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 607,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210320L, 96, 82, 41, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 608,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210320L, 81, 3, 50, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 609,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210320L, 91, 91, 23, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 610,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210320L, 81, 63, -7, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 611,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210320L, 4, 35, 36, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 612,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210320L, 42, 93, 12, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 613,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210320L, 93, 10, 17, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 614,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210320L, 59, 33, 2, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 615,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210320L, 9, 91, 48, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 616,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210320L, 27, 66, -4, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 617,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210320L, 93, 45, -17, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 618,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210320L, 63, 14, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 619,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210320L, 95, 61, -20, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 620,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210320L, 44, 98, 15, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 621,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210320L, 59, 4, 43, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 622,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210320L, 25, 42 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 623,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210320L, 82, 66, 37, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 624,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210320L, 47, 17, -17, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 625,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210320L, 19, 69, 19, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 626,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210320L, 70, 95, 2, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 627,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210320L, 75, 22, -3, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 628,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210320L, 11, 85, -20, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 629,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210320L, 80, 67, -5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 630,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210320L, 87, 78, 6, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 631,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 68, 50, 2, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 632,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 29, 85, -9, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 633,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 26, 55, 46, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 634,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210321L, 51, 91, 20, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 635,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Fresco", 20210321L, 22, 6, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 636,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210321L, 90, 89, 43, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 637,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210321L, 51, 8, 18, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 638,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 67, 53, 34, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 639,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 3, 56, -9, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 640,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210321L, 99, 41, 28, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 641,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 71, 26, 12, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 642,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 78, 27, -3, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 643,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210321L, 12, 94, -2, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 644,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210321L, 47, 3, 39, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 645,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210321L, 96, 23, -20, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 646,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210321L, 89, 2, 27, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 647,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 49, 89, 11, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 648,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210321L, 53, 36, -2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 649,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210321L, 84, 75, 13, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 650,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210321L, 36, 43, -4, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 651,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210321L, 91, 93, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 652,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210321L, 33, 30, -6, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 653,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210321L, 86, 38, -5, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 654,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210321L, 56, 44, 6, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 655,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210321L, 55, 50, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 656,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 34, 39, -2, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 657,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 96, 65, -6, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 658,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210321L, 23, 98, 16, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 659,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210321L, 58, 3, 50, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 660,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210321L, 60, 88, -15, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 661,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 65, 87, 37, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 662,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210322L, 33, 38, -12, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 663,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210322L, 48, 95, 40, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 664,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210322L, 12, 42, 21, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 665,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210322L, 60, 21, 7, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 666,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 84, 91, 9, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 667,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210322L, 21, 79, 7, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 668,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 18, 0, 4, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 669,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 67, 65, -13, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 670,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 46, 55, 54, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 671,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 75, 28, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 672,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210322L, 70, 26, 21, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 673,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 2, 53, -5, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 674,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 80, 73, -19, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 675,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 14, 23, 21, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 676,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210322L, 0, 54, 33, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 677,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 18, 44, 43, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 678,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 10, 46, 25, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 679,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 61, 30, -16, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 680,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 74, 62, 22, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 681,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210322L, 41, 74, -2, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 682,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210322L, 90, 60, 10, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 683,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 70, 26, -20, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 684,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210322L, 44, 35, 36, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 685,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 93, 63, 21, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 686,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210322L, 53, 61, -2, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 687,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 37, 80, -14, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 688,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 22, 2, -13, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 689,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210322L, 89, 55, -20, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 690,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Soleado", 20210322L, 27, 59, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 691,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 79, 18, -5, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 692,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210323L, 87, 81, 25, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 693,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210323L, 13, 7, 39, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 694,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 65, 88, -5, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 695,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 3, 34, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 696,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210323L, 14, 74, 54, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 697,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210323L, 43, 34, 28, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 698,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 13, 0, 47, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 699,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210323L, 92, 15, 1, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 700,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 2, 42, 49, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 701,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210323L, 89, 93, 48, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 702,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 41, 14, -15, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 703,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 84, 66, 44, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 704,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210323L, 26, 64, 13, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 705,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210323L, 99, 75, -6, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 706,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210323L, 56, 21, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 707,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210323L, 72, 22, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 708,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210323L, 75, 44, 33, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 709,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 26, 59, 36, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 710,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 47, 30, 26, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 711,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210323L, 28, 15, 1, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 712,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210323L, 88, 94, -8, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 713,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210323L, 80, 58, 44, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 714,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210323L, 11, 30, -10, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 715,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 56, 88, -20, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 716,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210323L, 72, 48, 24, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 717,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210323L, 37, 73, -1, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 718,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210323L, 66, 43, 10, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 719,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210323L, 22, 56, 37 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 720,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210323L, 85, 79, -8, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 721,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210324L, 97, 19, 3, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 722,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 61, 59, 9, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 723,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210324L, 36, 22, 30, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 724,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210324L, 53, 21, -11, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 725,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210324L, 49, 64, 32, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 726,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 45, 65, 13, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 727,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 27, 63, 40, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 728,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210324L, 73, 76, -15, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 729,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 31, 82, 41, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 730,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 21, 20, 21, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 731,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 60, 25, 51, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 732,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210324L, 25, 69, 30, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 733,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210324L, 13, 14, 35 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 734,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210324L, 18, -18, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 735,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 58, 47, 7, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 736,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 38, 32, 45, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 737,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 67, 43, -3, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 738,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 25, 2, 21, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 739,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 89, 50, 8, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 740,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 14, 68, 30, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 741,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 43, 1, 25, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 742,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210324L, 13, 66, 16, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 743,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 65, 31, 5, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 744,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 73, 47, 2, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 745,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210324L, 66, 69, -20, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 746,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210324L, 52, 57, 44, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 747,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 97, 17, -6, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 748,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 15, 0, -3, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 749,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210324L, 82, 89, 46, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 750,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210324L, 30, 84, -16, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 751,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 18, 95, -6, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 752,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 20, 34, 48, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 753,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Lluvioso", 20210325L, 70, 13, 48 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 754,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210325L, 11, 33, -8, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 755,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210325L, 3, 31, 2, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 756,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 91, 87, -12, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 757,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210325L, 11, 27, -20, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 758,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210325L, 71, 98, -3, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 759,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 52, 80, 46, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 760,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 32, 18, 36, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 761,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210325L, 34, 73, 34, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 762,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 96, 91, 46, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 763,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 17, 42, -18, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 764,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210325L, 1, 2, 27, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 765,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210325L, 63, 62, -7, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 766,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210325L, 19, 78, 16, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 767,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 74, 55, 49, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 768,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 11, 93, 0, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 769,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210325L, 72, 2, 4, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 770,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 71, 63, 14, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 771,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 55, 17, 34, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 772,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 11, 9, -13, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 773,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 56, 72, -13, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 774,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210325L, 67, 16, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 775,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 75, 90, 32, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 776,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 10, 89, -9, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 777,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 19, 6, 44, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 778,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 91, 99, 36, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 779,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210325L, 65, 81, -7, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 780,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210325L, 25, 46, 24, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 781,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210326L, 1, 44, 38 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 782,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 63, 41, 41, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 783,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210326L, 57, 98, -5, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 784,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 35, 53, -18, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 785,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 4, 76, 16, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 786,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 46, 25, 46, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 787,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 57, 63, 31, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 788,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210326L, 75, 5, 10, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 789,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210326L, 9, 36, 5, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 790,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 26, 24, -6, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 791,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 57, 11, -16, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 792,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 31, 39, -19, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 793,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210326L, 47, 95, 22, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 794,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 24, 41, 22, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 795,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Soleado", 20210326L, 62, 77, 53 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 796,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210326L, 61, 66, -11, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 797,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 26, 28, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 798,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 30, 6, 23, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 799,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 70, 73, -20, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 800,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210326L, 69, 89, 8, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 801,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 17, 99, 38, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 802,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 88, 49, 1, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 803,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210326L, 40, 78, 6, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 804,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 2, 68, 23, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 805,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 63, 10, 17, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 806,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210326L, 49, 7, -3, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 807,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210326L, 18, 97, -3, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 808,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210326L, 75, 81, 28, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 809,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210326L, 96, 18, -14, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 810,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210326L, 84, 33, -4, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 811,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210327L, 64, 86, 32, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 812,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210327L, 33, 36, 30, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 813,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 60, 99, -5, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 814,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 60, 8, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 815,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 32, 92, 37, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 816,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 62, 14, 4, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 817,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210327L, 32, 23, 47, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 818,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210327L, 18, 32, 7, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 819,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210327L, 92, 47, 1, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 820,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210327L, 15, 57, -14, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 821,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210327L, 38, 61, 26, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 822,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 66, 54, 37, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 823,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210327L, 42, 73, 20, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 824,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210327L, 16, 67, 53, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 825,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210327L, 75, 41, -16, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 826,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 12, 0, 2, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 827,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210327L, 96, 99, 36, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 828,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210327L, 46, 84, 1, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 829,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210327L, 53, 66, 42, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 830,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210327L, 53, 5, 20, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 831,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 18, 41, 11, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 832,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210327L, 65, 85, -5, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 833,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210327L, 52, 41, 37, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 834,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 2, 77, 20, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 835,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210327L, 79, 20, -10, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 836,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210327L, 18, 88, 9, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 837,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210327L, 52, 47, -2, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 838,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210327L, 30, 81, 5, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 839,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210327L, 64, 18, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 840,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210327L, 13, 13, 10, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 841,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210328L, 96, 2, 37, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 842,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210328L, 27, 61, -4, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 843,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210328L, 12, 67, 3, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 844,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210328L, 26, 89, 2, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 845,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 10, 46, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 846,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 19, 55, 51, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 847,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210328L, 24, 74, -1, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 848,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210328L, 23, 50, -4, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 849,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210328L, 79, 53, 34, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 850,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210328L, 31, 6, 36, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 851,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 58, 87, 18, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 852,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 2, 91, 2, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 853,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 66, 41, 29, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 854,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210328L, 23, 43, 22, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 855,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210328L, 74, 65, 39, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 856,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Fresco", 20210328L, 25, 66, -6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 857,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210328L, 13, 24, 46, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 858,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "Caluroso", 20210328L, 61, 16, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 859,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 82, 48, 2, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 860,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210328L, 86, 2, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 861,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210328L, 69, 82, 4, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 862,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210328L, 65, 13, 44, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 863,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 39, 66, 27, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 864,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210328L, 6, 27, 10, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 865,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210328L, 26, 81, 10, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 866,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210328L, 0, 83, 3, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 867,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 22, 61, 4, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 868,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210328L, 39, 54, -16, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 869,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210328L, 56, 50, -1, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 870,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210328L, 53, 8, 27, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 871,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 54, 80, -19, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 872,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210329L, 49, 55, 18, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 873,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 69, 12, -18, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 874,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210329L, 50, 43, -19, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 875,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210329L, 67, 88, 45, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 876,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 1, 24, 46, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 877,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 16, 29, -4, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 878,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 63, 7, 19, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 879,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 67, 4, 18, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 880,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210329L, 79, 81, -11, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 881,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210329L, 5, 58, -5, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 882,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 41, 12, -10, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 883,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210329L, 7, 54, 0, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 884,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210329L, 29, 95, 35, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 885,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 95, 80, 50, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 886,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210329L, 18, 21, 41, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 887,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210329L, 15, 44, -15, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 888,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210329L, 16, 23, 27, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 889,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210329L, 21, 66, 9, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 890,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Lluvioso", 20210329L, 33, 96, 52, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 891,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210329L, 27, 51, -8, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 892,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210329L, 86, 63, 10, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 893,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 64, 94, 49, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 894,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210329L, 42, 39, 41, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 895,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 57, 78, 17, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 896,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Caluroso", 20210329L, 85, 58, 0, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 897,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210329L, 38, 87, 43, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 898,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Soleado", 20210329L, 14, 16, 21, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 899,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210329L, 49, 37, 54, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 900,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "Fresco", 20210329L, 85, 1, 14, 21 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 1,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 22, 97, 32, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 2,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 81, 0, 7, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 3,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 98, 72, 46, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 4,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 19, 62, 42, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 5,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 80, 68, 47, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 6,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 83, 84, 8, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 7,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 66, 14, 12, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 8,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210301L, 98, 24, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 9,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 94, 25, -1, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 10,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 70, 40, 48, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 11,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 95, 65, -3, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 12,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 46, 63, 52, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 13,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 6, 73, 45, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 14,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 7, 37, 21, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 15,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 89, 83, -10, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 16,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 76, 92, 5, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 17,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 30, 80, 35, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 18,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 7, 87, 30, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 19,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 57, 25, 53, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 20,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 42, 46, 47, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 21,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 0, 0, 31, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 22,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 62, 22, -7, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 23,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 18, 9, -7, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 24,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 21, 48, 18, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 25,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 62, 31, 46, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 26,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 98, 87, 4, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 27,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 77, 57, 28, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 28,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 96, 35, 40, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 29,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 53, 10, 10, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 30,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210301L, 45, 67, 49, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 31,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 41, 42, -7, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 32,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 98, 0, 32, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 33,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 83, 26, -17, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 34,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 45, 27, 42, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 35,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 44, 0, -19, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 36,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 8, 32, 14, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 37,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 66, 51, -11, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 38,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 38, 88, 51, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 39,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 97, 10, 44, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 40,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 30, 40, 14, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 41,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 25, 27, 24, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 42,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 83, 38, 18, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 43,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 30, 72, 28, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 44,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 6, 84, -3, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 45,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 45, 58, 5, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 46,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 54, 58, 5, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 47,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 71, 61, 46, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 48,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 33, 54, 2, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 49,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 1, 79, 32, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 50,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 30, 55, -15, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 51,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 75, 52, 31, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 52,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 98, 47, 23, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 53,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 57, 12, -17, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 54,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 30, 12, 51, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 55,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 65, 8, 35, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 56,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 84, 10, 29, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 57,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 20, 67, 9, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 58,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 77, 88, 42, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 59,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210302L, 49, 70, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 60,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210302L, 58, 32, 41, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 61,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 68, 69, 26, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 62,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 67, 45, 53, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 63,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 44, 0, 16, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 64,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 8, 40, 47, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 65,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 83, 65, 31, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 66,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 18, 54, 0, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 67,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 60, 6, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 68,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 18, 49, 26, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 69,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 27, 24, 17, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 70,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 11, 67, 12, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 71,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 95, 62, -20, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 72,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 88, 78, 13, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 73,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 12, 92, 26, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 74,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 13, 68, 16, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 75,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 82, 52, 18, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 76,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 95, 43, 44, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 77,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 48, 3, 41, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 78,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 14, 11, -11, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 79,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210303L, 90, 89, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 80,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 71, 34, 24, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 81,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 62, 72, 47, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 82,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 92, 2, 8, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 83,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 45, 20, -12, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 84,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 7, 92, 43, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 85,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 1, 96, 30, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 86,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 75, 23, 2, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 87,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 62, 10, 38, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 88,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 48, 49, 38, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 89,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 29, 26, 40, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 90,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210303L, 60, 25, 40, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 91,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 54, 66, -12, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 92,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 17, 23, 29, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 93,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 97, 33, 41, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 94,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 25, 30, 4, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 95,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 92, 11, 52, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 96,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 3, 33, 9, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 97,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 10, 28, 34, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 98,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 75, 94, 27, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 99,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 30, 22, 7, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 100,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 83, 83, 31, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 101,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 76, 1, 49, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 102,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 83, 85, 18, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 103,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 16, 63, -20, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 104,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210304L, 39, 33, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 105,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 19, 92, 26, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 106,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 98, 58, -10, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 107,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 26, 55, 23, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 108,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 97, 61, -20, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 109,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 34, 38, 1, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 110,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 10, 58, 22, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 111,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 57, 60, 13, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 112,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 8, 6, 38, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 113,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 1, 52, 42, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 114,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 40, 45, 27, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 115,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 86, 89, -18, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 116,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 49, 72, 24, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 117,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 41, 2, 29, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 118,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 21, 1, 54, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 119,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 92, 33, 41, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 120,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210304L, 9, 98, -19, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 121,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210305L, 27, 23, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 122,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 49, 20, 24, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 123,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 35, 99, 53, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 124,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 27, 14, 34, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 125,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 32, 17, -12, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 126,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 4, 13, 28, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 127,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 94, 98, 3, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 128,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 32, 87, 20, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 129,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 47, 34, 39, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 130,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 80, 0, 13, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 131,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 97, 58, 19, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 132,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 31, 54, 29, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 133,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 41, 19, -16, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 134,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 86, 34, 29, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 135,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 17, 46, -6, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 136,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 28, 19, 0, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 137,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 87, 31, 30, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 138,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 27, 91, 29, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 139,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 22, 87, 7, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 140,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 5, -9, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 141,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 24, 26, 29, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 142,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 37, 48, 14, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 143,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 16, 13, 16, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 144,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 19, 19, 42, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 145,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 31, 87, 2, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 146,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 1, 94, 29, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 147,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 47, 30, 49, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 148,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 18, 80, -12, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 149,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210305L, 94, 40, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 150,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210305L, 63, 95, 51, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 151,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 88, 42, 50, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 152,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 27, 29, 36, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 153,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 76, 89, 31, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 154,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 10, 81, 35, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 155,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 41, 10, -2, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 156,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 33, 59, -20, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 157,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 67, 2, 51, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 158,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 37, -2, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 159,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 40, 13, -2, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 160,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 38, 48, -16, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 161,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 10, 29, -18, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 162,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 40, 90, -17, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 163,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 75, 23, 2, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 164,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 17, 46, 20, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 165,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 58, 21, -13, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 166,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210306L, 93, 83, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 167,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 4, 41, 18, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 168,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 66, 86, 10, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 169,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 13, 78, 33, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 170,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 63, 10, 16, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 171,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 12, 18, 26, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 172,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 81, 52, 12, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 173,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 14, 6, 52, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 174,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 1, 65, 47, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 175,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 70, 61, 6, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 176,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 7, 80, 44, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 177,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 13, 98, 22, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 178,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210306L, 86, 45, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 179,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 10, 53, 23, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 180,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210306L, 6, 92, 33, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 181,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 63, 27, 25, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 182,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 87, 82, 33, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 183,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210307L, 35, 93, 38 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 184,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 18, 0, 10, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 185,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 44, 68, -12, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 186,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 43, 6, 8, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 187,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 26, 16, -6, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 188,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 48, 58, 21, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 189,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 2, 71, 21, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 190,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 72, 72, -8, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 191,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 96, 8, -12, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 192,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 58, 99, -13, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 193,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 31, 28, 6, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 194,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 61, 61, 16, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 195,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 15, 13, 42, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 196,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 50, 51, 21, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 197,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 31, 92, 14, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 198,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 65, 59, 53, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 199,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 33, 69, 51, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 200,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 39, 3, -13, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 201,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 0, 69, 23, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 202,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 94, 45, 0, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 203,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210307L, 75, 49, -13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 204,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 19, 17, 23, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 205,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 94, 77, 23, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 206,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 58, 89, 30, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 207,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 7, 93, 26, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 208,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 43, 30, 0, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 209,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 97, 94, 35, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 210,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210307L, 92, 22, 17, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 211,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 59, 37, 53, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 212,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 80, 62, 43, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 213,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 71, 73, 17, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 214,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 52, 22, -13, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 215,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 64, 24, -13, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 216,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 66, 15, 8, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 217,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 29, 95, -17, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 218,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 9, 32, -5, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 219,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 19, 94, 44, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 220,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 91, 9, 2, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 221,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 29, 29, -10, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 222,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 70, 12, 24, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 223,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 76, 28, 11, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 224,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 61, 59, 23, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 225,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 44, 79, 33, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 226,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 57, 17, 5, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 227,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 46, 36, 27, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 228,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 39, 22, -19, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 229,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 19, 64, 4, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 230,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 20, 11, 44, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 231,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 20, 77, -2, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 232,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 76, 83, 22, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 233,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 58, 36, 4, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 234,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 65, 3, 29, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 235,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 90, 11, 34, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 236,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 48, 55, 29, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 237,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 92, 75, 46, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 238,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 97, 51, 9, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 239,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 63, 50, 24, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 240,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210308L, 61, 65, 52, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 241,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 82, 19, 24, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 242,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 34, 89, 27, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 243,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 37, 22, 54, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 244,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 27, 97, -4, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 245,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 2, 0, 1, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 246,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210309L, 86, 83, 48 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 247,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 90, 99, 9, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 248,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 99, 9, 9, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 249,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 62, 10, 17, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 250,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 56, 83, 34, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 251,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 94, 62, 10, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 252,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 38, 22, -9, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 253,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 27, 93, -3, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 254,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 89, 81, 26, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 255,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 26, 0, 5, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 256,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 90, 20, 54, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 257,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 25, 30, -3, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 258,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210309L, 97, 81, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 259,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 39, 2, 12, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 260,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 66, 69, 46, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 261,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 90, 27, 25, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 262,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210309L, 44, 2, 41 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 263,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 12, 86, -5, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 264,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210309L, 1, 92, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 265,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 93, 4, 34, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 266,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 27, 26, 53, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 267,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 53, 82, 52, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 268,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 87, 61, 12, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 269,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 3, 9, 5, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 270,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210309L, 7, 44, 2, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 271,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 90, 57, 43, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 272,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 88, 24, 31, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 273,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 55, 18, -19, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 274,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 19, 82, 36, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 275,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 49, 48, -20, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 276,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 25, 85, 17, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 277,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 37, 48, 54, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 278,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210310L, 91, 30, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 279,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 99, 73, 52, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 280,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 74, 78, 7, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 281,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 58, 1, 50, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 282,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 88, 3, -16, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 283,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 70, 69, 47, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 284,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 70, 8, 51, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 285,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 49, 30, 4, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 286,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 62, 40, 45, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 287,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 87, 27, 0, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 288,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 97, 79, 42, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 289,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 5, 78, 35, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 290,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 54, 0, 0, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 291,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 58, 85, 25, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 292,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 32, 10, 25, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 293,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210310L, 7, 99, -18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 294,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 84, 54, 1, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 295,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 97, 87, 8, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 296,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 69, 86, -8, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 297,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 7, 48, 33, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 298,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 72, 22, -19, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 299,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 59, 54, 36, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 300,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210310L, 10, 43, 41, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 301,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 99, 98, 51, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 302,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 92, 91, 33, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 303,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 9, 52, 50, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 304,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 78, 77, -18, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 305,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 47, 48, -8, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 306,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 86, 16, -19, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 307,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 30, 76, 0, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 308,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 71, 82, 51, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 309,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 82, 81, 37, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 310,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 38, 86, 45, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 311,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 23, 88, 22, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 312,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 28, 32, -11, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 313,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 85, 85, 36, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 314,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 14, 99, 52, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 315,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 56, 18, -12, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 316,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 23, 17, 25, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 317,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 63, 14, 40, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 318,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 86, 60, 50, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 319,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 55, 67, -12, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 320,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 67, 36, 49, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 321,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 99, 32, 15, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 322,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 98, 38, 53, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 323,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 6, 3, 30, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 324,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210311L, 19, 42, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 325,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 68, 12, 29, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 326,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 4, 7, 31, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 327,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 22, 54, 53, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 328,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 85, 0, 12, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 329,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 48, 61, 18, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 330,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210311L, 12, 12, -7, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 331,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210312L, 54, 86, -9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 332,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 0, 18, 20, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 333,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 47, 16, 16, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 334,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 26, 69, 31, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 335,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 11, 84, 0, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 336,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 33, 70, -8, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 337,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 17, 31, -7, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 338,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 20, 50, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 339,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210312L, 82, 25, 54 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 340,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 61, 13, 19, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 341,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 79, 53, 20, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 342,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 6, 5, 19, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 343,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 0, 8, 5, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 344,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 26, 69, -20, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 345,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 72, 88, 19, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 346,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 74, 31, -19, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 347,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 81, 94, 51, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 348,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 87, 44, 45, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 349,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 88, 31, -3, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 350,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 13, 5, 47, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 351,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 34, 35, -1, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 352,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 52, 86, 47, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 353,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 29, 36, 54, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 354,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 78, 39, 10, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 355,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 31, 22, 39, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 356,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 94, 63, -2, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 357,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 11, 86, -5, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 358,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 54, 64, 40, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 359,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 96, 60, 35, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 360,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210312L, 68, 88, 53, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 361,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 44, 51, 11, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 362,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 73, 23, -9, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 363,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 82, 66, 19, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 364,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 87, 56, 35, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 365,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 65, 44, 10, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 366,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 48, 82, 36, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 367,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 89, 82, 41, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 368,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 24, 12, 12, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 369,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 15, 22, 20, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 370,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 73, 43, -6, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 371,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 16, 27, -11, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 372,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 72, 86, 41, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 373,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210313L, 24, 34, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 374,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 33, 65, -3, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 375,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 68, 10, -19, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 376,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 40, 93, 5, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 377,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 14, 90, 11, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 378,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 42, 14, 10, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 379,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 90, 68, 33, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 380,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 51, 34, 30, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 381,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 7, 70, -13, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 382,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 68, 72, 45, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 383,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 70, 55, 47, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 384,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 62, 40, 36, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 385,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 73, 75, 45, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 386,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 77, 21, 33, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 387,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 81, 27, 48, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 388,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 92, 85, 35, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 389,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 23, 73, 24, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 390,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210313L, 52, 31, 44, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 391,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 61, 26, -3, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 392,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 22, 33, 13, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 393,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 59, 71, -16, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 394,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 23, 59, 25, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 395,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 17, 49, 49, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 396,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210314L, 14, 13, 48 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 397,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 50, 2, 27, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 398,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 32, 99, -8, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 399,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210314L, 68, 3, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 400,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 13, 92, 25, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 401,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 49, 50, -17, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 402,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 7, 1, -1, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 403,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 70, 36, 17, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 404,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 78, 92, -11, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 405,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 22, 58, -11, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 406,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 14, 21, 42, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 407,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 69, 3, 9, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 408,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 27, 78, 48, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 409,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210314L, 56, 60, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 410,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 77, 11, 28, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 411,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 51, 50, 50, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 412,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 43, 96, 1, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 413,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 33, 59, -1, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 414,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 73, 71, 32, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 415,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 62, 42, 6, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 416,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 8, 50, 4, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 417,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210314L, 0, 69, -14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 418,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 45, 37, 7, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 419,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 47, 61, 40, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 420,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210314L, 77, 34, 32, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 421,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 31, 38, 24, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 422,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 31, 25, 13, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 423,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 4, 73, 45, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 424,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 28, 55, 16, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 425,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 71, 79, 11, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 426,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 93, 90, 52, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 427,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 32, -10, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 428,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 12, 40, -3, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 429,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 62, 19, 28, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 430,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 26, 76, -6, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 431,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 65, 35, 8, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 432,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 51, 23, 4, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 433,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 91, 3, 4, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 434,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 47, 17, 27, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 435,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 17, 44, 13, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 436,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 41, 22, -17, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 437,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 56, 3, 25, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 438,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 24, 35, 49, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 439,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 21, 89, 20, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 440,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 54, 31, -1, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 441,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 75, 96, 40, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 442,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 38, 22, 16, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 443,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 48, 93, 34, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 444,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 78, 13, 24, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 445,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 1, 18, 50, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 446,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 32, 22, 29, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 447,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 36, 25, 39, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 448,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 43, 86, 51, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 449,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 31, 27, 47, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 450,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210315L, 21, 15, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 451,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 56, 9, 29, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 452,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 6, 49, 45, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 453,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210316L, 66, 6, -12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 454,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 23, 25, 2, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 455,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 40, 79, 27, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 456,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 51, 64, 44, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 457,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 35, 17, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 458,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210316L, 68, 70, 41 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 459,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 63, 62, -5, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 460,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 9, 33, 29, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 461,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 62, 97, -6, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 462,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 83, 35, -6, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 463,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 43, 73, -17, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 464,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 53, 74, 40, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 465,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 48, 69, 23, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 466,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 57, 75, 28, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 467,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 87, 94, 8, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 468,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 91, 66, 25, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 469,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 4, 11, 31, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 470,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 67, 62, -19, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 471,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 26, 20, 19, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 472,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 92, 0, 0, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 473,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 99, 63, -14, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 474,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 65, 57, 43, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 475,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 50, 22, 10, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 476,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 3, 15, 16, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 477,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 98, 13, 41, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 478,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 98, 65, 32, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 479,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210316L, 99, 34, -19, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 480,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210316L, 13, 48, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 481,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 59, -19, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 482,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 44, 94, 30, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 483,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 47, 60, 14, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 484,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210317L, 65, 42, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 485,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 26, 89, -7, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 486,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 75, 23, -19, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 487,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 94, 4, 28, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 488,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 95, 22, 23, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 489,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210317L, 23, 12, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 490,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 69, 5, 21, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 491,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 23, 87, 31, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 492,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 82, 20, -7, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 493,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 25, 62, 31, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 494,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 35, 99, -4, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 495,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 34, 15, 29, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 496,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 53, 93, 54, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 497,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 68, 55, 29, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 498,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 80, 57, -6, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 499,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 44, 38, -6, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 500,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 25, 66, 54, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 501,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 82, 35, -4, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 502,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 69, 36, 52, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 503,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 42, 45, 38, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 504,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 87, 6, 33, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 505,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 43, 0, 5, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 506,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 40, 82, 18, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 507,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 39, 13, 41, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 508,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 78, 20, 21, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 509,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 41, 90, 48, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 510,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210317L, 58, -12, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 511,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 22, 58, 45, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 512,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 41, 40, -9, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 513,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 81, 69, 18, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 514,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 92, 62, -3, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 515,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 13, 71, 50, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 516,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 54, 85, 52, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 517,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 49, 43, 30, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 518,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 63, 23, 28, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 519,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 75, 13, 35, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 520,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 95, 67, 25, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 521,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 33, 26, 33, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 522,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 74, 79, 9, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 523,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 70, 3, 53, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 524,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION" },
                values: new object[] { "", 20210318L, 33, 43 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 525,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 6, 64, -17, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 526,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 48, 60, 48, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 527,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 24, 5, -16, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 528,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 78, 0, 45, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 529,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 11, 72, 37, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 530,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210318L, 18, 68, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 531,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 83, 20, 31, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 532,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 31, 24, 19, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 533,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 88, 74, 40, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 534,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 49, 23, 25, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 535,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 80, 5, 38, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 536,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 41, 64, 21, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 537,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 62, 43, -2, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 538,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 49, 62, 3, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 539,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 2, 19, 14, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 540,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210318L, 74, 86, 37, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 541,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 30, 93, 35, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 542,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 66, 82, -11, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 543,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 92, 0, -3, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 544,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 32, 84, 46, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 545,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 36, 86, 39, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 546,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 99, 58, 25, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 547,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 49, 52, -2, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 548,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 33, 78, -5, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 549,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 59, 98, 3, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 550,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 84, 28, 5, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 551,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 49, 9, 37, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 552,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 46, 3, 33, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 553,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 91, 97, 45, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 554,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 20, 65, 17, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 555,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 88, 12, 50, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 556,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 32, 25, 5, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 557,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 15, 1, 30, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 558,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 71, 71, -2, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 559,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 33, 94, -20, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 560,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 46, 69, -13, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 561,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 53, 86, -16, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 562,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 40, 42, 45, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 563,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 66, 44, 38, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 564,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 8, 25, 9, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 565,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 63, 4, 37, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 566,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 37, 56, 46, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 567,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 90, 39, -1, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 568,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 6, 68, 3, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 569,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 53, 67, 29, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 570,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210319L, 58, 9, 34, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 571,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 12, 49, 25, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 572,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 11, 49, -17, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 573,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 74, 82, 45, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 574,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 32, 76, -16, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 575,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 97, 37, 17, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 576,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 34, 85, 19, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 577,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 55, 41, 8, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 578,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 78, 61, 33, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 579,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 9, 38, 14, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 580,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 11, 56, 12, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 581,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 68, 14, 1, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 582,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 19, 0, 50, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 583,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 96, 3, 6, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 584,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 72, 11, -12, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 585,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 42, 3, -9, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 586,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 3, 39, 51, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 587,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 59, 7, -17, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 588,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 6, 93, 30, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 589,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 18, 21, -1, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 590,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 14, 85, -7, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 591,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 36, 65, -4, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 592,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 55, 43, 28, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 593,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 23, 35, 29, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 594,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 81, 47, -11, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 595,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 44, 43, -12, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 596,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 21, 51, 11, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 597,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 8, 3, 53, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 598,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 57, 34, 49, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 599,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210320L, 40, 5, 47 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 600,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210320L, 60, 35, -18, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 601,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 0, 24, 18, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 602,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 80, 66, 32, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 603,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 27, 9, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 604,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 95, 27, 10, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 605,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 95, 13, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 606,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 42, 65, 5, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 607,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 50, 93, 38, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 608,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 84, 52, -15, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 609,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 35, 83, 41, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 610,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 71, 89, 18, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 611,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 50, 30, -3, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 612,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 89, 82, -15, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 613,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 84, 70, -13, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 614,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 26, 99, 28, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 615,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 54, 68, 41, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 616,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 71, 73, -8, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 617,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 91, 52, 14, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 618,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 19, 49, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 619,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 38, 40, -3, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 620,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 25, 81, -9, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 621,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 97, 88, -17, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 622,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210321L, 76, 30 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 623,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 35, 49, 22, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 624,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 14, 95, 6, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 625,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 15, 63, 24, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 626,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 69, 31, 48, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 627,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 84, 30, 18, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 628,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 71, 22, 25, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 629,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210321L, 71, 58, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 630,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210321L, 19, 35, 37, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 631,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 0, 8, 11, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 632,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 18, 35, 12, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 633,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 44, 88, -1, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 634,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 4, 70, 29, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 635,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210322L, 84, 65, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 636,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 22, 86, 49, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 637,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 40, 34, 38, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 638,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 73, 85, -2, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 639,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 13, 46, 12, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 640,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 88, 27, 3, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 641,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 98, 56, -12, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 642,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 34, 19, 38, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 643,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 9, 98, 20, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 644,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 76, 82, 17, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 645,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 64, 66, 45, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 646,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 3, 42, 51, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 647,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 7, 20, -9, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 648,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210322L, 41, 22, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 649,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 25, 69, 37, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 650,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 55, 50, 45, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 651,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210322L, 22, 68, 54 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 652,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 73, 62, 37, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 653,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 95, 58, 32, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 654,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 20, 79, 26, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 655,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210322L, 56, 58, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 656,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 14, 14, -11, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 657,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 33, 17, 22, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 658,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 67, 40, 22, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 659,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 9, 6, -12, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 660,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210322L, 63, 77, -5, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 661,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 50, 46, 15, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 662,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 29, 77, 0, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 663,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 83, 56, 16, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 664,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 45, 98, 50, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 665,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 69, 89, 20, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 666,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 5, 93, 1, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 667,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 53, 58, 47, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 668,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 49, 94, 32, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 669,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 10, 3, 51, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 670,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 5, 15, 28, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 671,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 35, 46, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 672,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 43, 38, 22, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 673,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 72, 24, 25, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 674,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 24, 4, -15, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 675,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 8, 20, 10, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 676,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 28, 73, -3, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 677,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 34, 8, -15, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 678,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 20, 79, 45, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 679,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 71, 90, 43, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 680,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 72, 6, 25, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 681,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 94, 40, -9, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 682,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 67, 19, -4, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 683,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 25, 57, 39, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 684,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 55, 36, -15, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 685,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 92, 78, -15, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 686,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 25, 53, -17, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 687,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 45, 34, -17, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 688,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 93, 31, 4, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 689,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210323L, 53, 56, 16, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 690,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210323L, 31, 83, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 691,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 9, 43, 10, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 692,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 30, 76, 20, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 693,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 85, 56, 5, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 694,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 47, 24, -10, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 695,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 40, -9, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 696,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 57, 50, 35, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 697,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 95, 90, 27, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 698,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 35, 73, 42, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 699,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 7, 4, 15, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 700,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 26, 95, 12, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 701,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 82, 97, -18, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 702,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 20, 11, 14, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 703,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 66, 92, -14, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 704,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 13, 43, 12, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 705,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 66, 61, 44, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 706,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210324L, 64, 80, 40 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 707,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 61, -4, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 708,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 17, 87, -8, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 709,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 84, 12, 45, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 710,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 2, 81, 30, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 711,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 41, 71, 32, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 712,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 80, 69, -16, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 713,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 74, 16, 47, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 714,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 46, 62, 1, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 715,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 55, 21, 4, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 716,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 6, 11, 36, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 717,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 77, 46, 36, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 718,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 23, 37, 24, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 719,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210324L, 93, 13, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 720,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210324L, 54, 73, 8, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 721,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 18, 32, 40, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 722,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 91, 34, -11, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 723,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 43, 60, 29, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 724,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 77, 16, -1, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 725,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 16, 20, 28, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 726,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 43, 49, 49, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 727,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 22, 69, 49, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 728,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 85, 36, 31, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 729,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 4, 3, 30, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 730,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 8, 5, 49, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 731,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 65, 52, 20, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 732,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 79, 78, 50, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 733,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210325L, 46, 35, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 734,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 59, 22, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 735,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 9, 65, 46, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 736,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 56, 77, -11, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 737,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 78, 83, 36, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 738,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 64, 33, -12, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 739,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 5, 76, -12, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 740,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 58, 45, 43, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 741,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 78, 80, 47, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 742,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 3, 67, 47, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 743,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 54, 74, 12, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 744,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 27, 64, 52, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 745,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 22, 36, 52, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 746,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 30, 56, -20, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 747,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 5, 87, 33, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 748,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 45, 20, 46, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 749,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 53, 95, -16, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 750,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210325L, 38, 23, 53, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 751,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 78, 5, 40, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 752,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 62, 36, 39, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 753,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210326L, 42, 28, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 754,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 12, 48, -4, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 755,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 61, 75, 16, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 756,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 83, 22, 26, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 757,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 21, 11, 1, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 758,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 78, 95, -12, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 759,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 30, 15, 53, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 760,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 24, 93, 38, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 761,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 31, 58, -2, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 762,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 21, 98, 38, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 763,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 82, 19, 42, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 764,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 46, 35, 26, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 765,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 8, 55, -4, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 766,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 35, 61, -9, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 767,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 50, 70, 17, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 768,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 55, 17, -7, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 769,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 78, 27, 18, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 770,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 46, 23, 48, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 771,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 18, 62, 47, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 772,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 10, 55, -11, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 773,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 73, 73, 31, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 774,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 56, 43, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 775,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 11, 79, -3, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 776,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 41, 14, 15, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 777,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 72, 26, 27, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 778,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 65, 43, 23, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 779,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 77, 78, -14, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 780,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210326L, 39, 43, 12, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 781,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210327L, 37, 87, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 782,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 71, 33, 12, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 783,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 79, 14, -14, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 784,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 82, 38, -12, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 785,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 28, 53, -4, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 786,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 4, 75, 42, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 787,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 13, 75, -15, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 788,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 20, 65, 39, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 789,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 47, 17, 9, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 790,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 21, 97, 37, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 791,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 26, 78, 21, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 792,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 86, 53, 27, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 793,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 31, 1, 51, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 794,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 10, 52, -9, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 795,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210327L, 36, 11, 42 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 796,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 14, 64, -6, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 797,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 72, 50, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 798,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 99, 22, 48, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 799,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 30, 98, 3, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 800,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 62, 61, 16, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 801,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 10, 43, 46, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 802,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 65, 29, 5, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 803,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 77, 61, -15, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 804,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 10, 52, 25, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 805,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 48, 82, 27, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 806,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 78, 92, 40, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 807,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 58, 7, -18, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 808,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 36, 5, -4, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 809,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 79, 82, 17, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 810,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210327L, 9, 37, 20, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 811,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 87, 85, 4, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 812,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 63, 34, 13, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 813,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 41, 40, 45, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 814,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 96, -11, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 815,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 74, 37, 28, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 816,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 64, 49, 33, 0 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 817,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 14, 56, -1, 23 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 818,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 36, 34, 35, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 819,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 32, 84, 34, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 820,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 28, 48, -17, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 821,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 29, 79, 12, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 822,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 7, 69, 27, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 823,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 10, 82, -13, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 824,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 93, 82, 26, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 825,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 3, 85, -5, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 826,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 5, 85, -6, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 827,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 93, 15, -18, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 828,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 92, 78, 28, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 829,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 83, 6, -14, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 830,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 38, 83, -5, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 831,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 68, 61, 16, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 832,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 63, 19, -3, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 833,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 73, 48, 48, 5 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 834,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 48, 40, 13, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 835,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 77, 76, 35, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 836,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 88, 79, 37, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 837,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 8, 94, 47, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 838,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 63, 1, 54, 11 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 839,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210328L, 39, 47, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 840,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210328L, 29, 14, -7, 25 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 841,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 37, 3, 18, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 842,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 72, 74, -17, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 843,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 17, 26, 22, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 844,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 80, 90, -17, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 845,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "VIENTO" },
                values: new object[] { "", 20210329L, 0, 36, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 846,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 90, 7, -13, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 847,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 70, 35, 43, 29 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 848,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 39, 90, -19, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 849,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 95, 93, 15, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 850,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 27, 72, 10, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 851,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 99, 41, -4, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 852,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 33, 19, 43, 17 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 853,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 85, 69, 30, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 854,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 73, 99, -10, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 855,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 30, 48, -11, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 856,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210329L, 65, 75, -18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 857,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 96, 58, 45, 3 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 858,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA" },
                values: new object[] { "", 20210329L, 28, 7, 51 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 859,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 7, 84, -13, 20 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 860,
                columns: new[] { "CLIMA", "FECHA", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 18, -14, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 861,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 29, 13, -19, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 862,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 45, 58, -16, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 863,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 60, 51, -6, 27 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 864,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 12, 58, 11, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 865,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 86, 32, 36, 7 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 866,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 61, 21, -3, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 867,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 71, 85, 10, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 868,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 36, 4, 49, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 869,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 66, 65, 13, 26 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 870,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210329L, 60, 33, 14, 8 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 871,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 92, 50, -11, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 872,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 57, 36, 14, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 873,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 93, 60, 34, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 874,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 42, 78, 3, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 875,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 91, 69, 18, 6 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 876,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 54, 16, 45, 4 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 877,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 47, 66, -9, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 878,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 1, 23, 49, 12 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 879,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 13, 57, 33, 21 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 880,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 13, 18, 2, 1 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 881,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 56, 20, 0, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 882,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 62, 60, -12, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 883,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 37, 85, -3, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 884,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 41, 40, 11, 28 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 885,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 28, 77, 51, 24 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 886,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 59, 81, 46, 14 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 887,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 3, 51, 24, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 888,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 51, 69, 28, 10 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 889,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 92, 86, 21, 19 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 890,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 3, 21, 24, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 891,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 52, 81, -17, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 892,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 99, 24, 44, 9 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 893,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 76, 17, -9, 15 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 894,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 15, 33, 47, 13 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 895,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 72, 8, 26, 18 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 896,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 2, 87, 22, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 897,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 21, 3, 5, 16 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 898,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 37, 75, 16, 22 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 899,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 76, 73, 35, 2 });

            migrationBuilder.UpdateData(
                table: "PRONOSTICO",
                keyColumn: "ID_PRONOSTICO",
                keyValue: 900,
                columns: new[] { "CLIMA", "FECHA", "HUMEDAD", "PRECIPITACION", "TEMPERATURA", "VIENTO" },
                values: new object[] { "", 20210330L, 62, 52, 2, 10 });
        }
    }
}
