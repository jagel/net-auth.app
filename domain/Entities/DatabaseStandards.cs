using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public static class DatabaseStandards
    {
        public static int ENUM_NAME = 20;
        public static int KEY_NAME = 10;
        public static int KEYLONG_NAME = 100;

        public static int I18N_KEYNAME = 20;

        public static int NAME_LENGHT = 100;
        public static int DESCRIPTION_LENGHT = 200;
        public static int BARCODE_LENGHT = 40;

        public static int CYPHER_GUID = 200;

        public static string SQL_DATETIME = "datetime2";
        public static string SQL_SETCURRENTTIME = "GETUTCDATE()";

        public static string SQL_DECIMALTWOPLACES = "decimal(10,2)";
    }
}
