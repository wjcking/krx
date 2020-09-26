using System;
using System.Text;
using JiebaNet.Segmenter;
using JiebaNet.Analyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JiebaNet.Segmenter.PosSeg;
using System.Linq;
using System.Collections.Generic;
    /// <summary>
    ///     1 2 3
    /// C 1 0 0 0 C
    ///   2 0 0 0 1
    ///   3 0 0 0
    /// C 4 0 0 0 C
    /// 类似于传真引线
    /// </summary>
    public enum RectCorner
    {
        TopLeft = 0,
        TopRight = 1,
        BottomLeft = 2,
        BottomRight = 3
    }
namespace Compiler
{

    /// <summary>
    /// compiler
    /// </summary>
    [TestClass]
    public class Compiler
    {
        public class Basic
        {
            Encoding encoding = Encoding.Default;
            ushort Language = 0;
            string text;
            char[] Spliter;
            char[] Bracket;
        }
        [TestMethod]
        public void Jieba()
        {
            //JiebaSegmenter seg = new JiebaSegmenter();
            //var analyser = new JiebaNet.Analyser.TextRankExtractor();
            ////   analyser.ExtractTags("adsf", 2);
            var asdf = "今天 面削 ？。平不平税" + Environment.NewLine;
            asdf += "什么时候才能阿跳跃斯蒂芬金康 232" + Environment.NewLine;
            asdf += "This is a knaif but time will tall" + Environment.NewLine;
            asdf += " 后在日攻击都大学深造" + Environment.NewLine;
            var posSeg = new PosSegmenter();
            asdf +=   "一团硕大无朋的高能离子云，在遥远而神秘的太空中迅疾地飘移";
            
            var tokens = posSeg.Cut(asdf);
           
            Console.WriteLine(string.Join(Environment.NewLine, tokens.Select(token => string.Format("{0}:{1}", token.Word, token.Flag))));

            //var segmenter = new JiebaSegmenter(); 
            // var token2  = segmenter.Tokenize(asdf, TokenizerMode.Default); 
            //foreach (var t in token2)
            //{
            //    Console.WriteLine("{0}: {0,-12} start: {1,-3} end: {2,-3}", t.Word, t.StartIndex,t.EndIndex);
            //}

            //  var analyser = new JiebaNet.Analyser.TextRankExtractor();
            var analyser = new JiebaNet.Analyser.TextRankExtractor();
            var pos = new List<string>() {"n","v"};
            var list = analyser.ExtractTagsWithWeight(asdf, 20, pos);
            Console.WriteLine(Environment.NewLine);
            foreach (var t in list)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }


}
