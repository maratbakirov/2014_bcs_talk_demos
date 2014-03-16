using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BCSCodeModel.CodeMOdel
{
    public class CodeEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public partial class CodeEntityService
    {
        public static CodeEntity ReadItem(int iD)
        {
            return new CodeEntity()
            {ID = iD, Name = "Name " + iD};
        }

        public static IEnumerable<CodeEntity> ReadList()
        {
            for (int iD = 0; iD < 100; iD++)
            {
                yield return new CodeEntity()

                {ID = iD, Name = "Name " + iD};
            }
        }
    }
}
