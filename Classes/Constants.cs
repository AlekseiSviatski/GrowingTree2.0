using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingTree2._0
{
    class Constants
    {
        public const string warning = "Предупреждение! ";
        public const string warningMessage = "Не удалось добавить информацию в базу данных! ";
        public const string fieldsWarning = "Поля информации о дереве не могут быть пустыми! ";
        public const string clearArtuhovWateringCount = "UPDATE Persons SET WateringCount = 0 WHERE IDPerson = 1";
        public const string clearSviatskiWateringCount = "UPDATE Persons SET WateringCount = 0 WHERE IDPerson = 2";
        public const string clearKoshelWateringCount = "UPDATE Persons SET WateringCount = 0 WHERE IDPerson = 3";
    }
}
