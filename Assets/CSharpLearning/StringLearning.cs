using UnityEngine;

namespace CSharpLearning
{
    /// <summary>
    /// String 类是 System.String 类的别名，它是从对象（Object）类型中派生的。所以String是一种引用类型
    /// </summary>
    public class StringLearning : MonoBehaviour
    {
        [ContextMenu("VerbatimString")]
        public void VerbatimString()
        {
            // 使用@" "形式声明的字符串称为“逐字字符串”
            // 逐字字符串会将转义字符\当作普通字符对待
            // 以下两个字符串是等价的
            // 另外，在@" "形式声明的字符串中可以任意使用换行，换行符及缩进空格等都会计算在字符串的长度之中。
            var str1 = @"C:\Windows";
            var str2 = "C:\\Windows";
            
            Debug.Log(str1);    //C:\Windows
            Debug.Log(str2);    //C:\Windows
        }
    }
}