/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Importing a namespace can result in type-name collision. Rathern than 
 importing the whole namespace, you can import just the specific types you need,
 giving each type an alias. For Example: */
using PropertyInfo2 = System.Reflection.PropertyInfo;
using R = System.Reflection;
class Program { PropertyInfo2 p; }
// An entire namespace can be aliased, as follows:
class Program2 { R.PropertyInfo p; }
namespace Aliasing_Types_and_Namespaces
{
    class Program
    {
        static void Main()
        {
            
        }
    }
}
