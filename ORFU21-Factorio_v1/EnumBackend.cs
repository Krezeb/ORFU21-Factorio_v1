using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Factorio_v1
{
    public static class EnumBackend
    {
        public static string GetDisplayName(this Enum input)
        {
            FieldInfo fieldInfo = input.GetType().GetField(input.ToString());
            return input.ToString();
        }
    }
}