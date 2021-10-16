using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Factorio_v1
{
    public enum ItemTypesEnum
    {
        //[Description("Wood")] Wood = 1,
        //[Description("Glass")] Glass = 2,
        //[Description("Rubber")] Rubber = 3,
        //[Description("Metal")] Metal = 4, 
        //[Description("Wood Tables")] WoodTable = 10,
        //[Description("Glass Tables")] GlassTable = 11,
        //[Description("Rubber Tables")] RubberTable = 12,
        //[Description("Metal Tables")] MetalTable = 13,

        [Display(Name = "Wood")] Wood = 0,
        [Display(Name = "Glass")] Glass = 1,
        [Display(Name = "Rubber")] Rubber = 2,
        [Display(Name = "Metal")] Metal = 3,
        [Display(Name = "Wood Table")] WoodTable = 10,
        [Display(Name = "Glass Table")] GlassTable = 11,
        [Display(Name = "Rubber Table")] RubberTable = 12,
        [Display(Name = "Metal Table")] MetalTable = 13,
    }
}
