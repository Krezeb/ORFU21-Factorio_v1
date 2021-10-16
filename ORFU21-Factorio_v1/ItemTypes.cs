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
        [Display(Name = "Wood")] Wood = 0,
        [Display(Name = "Glass")] Glass = 1,
        [Display(Name = "Rubber")] Rubber = 2,
        [Display(Name = "Metal")] Metal = 3,
        [Display(Name = "Wood Table")] WoodTable = 10,
        [Display(Name = "Glass Table")] GlassTable = 11,
        [Display(Name = "Rubber Table")] RubberTable = 12,
        [Display(Name = "Metal Table")] MetalTable = 13,
    }

    public enum BlueprintEnum
    {
        [Display(Name = "Wood Table Blueprint")] WoodTableBP = 0,
        [Display(Name = "Glass Table Blueprint")] GlassTableBP = 1,
        [Display(Name = "Rubber Table Blueprint")] RubberTableBP = 2,
        [Display(Name = "Metal Table Blueprint")] MetalTableBP = 3,
    }
}
