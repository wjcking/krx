using JiebaNet.Segmenter.PosSeg;
using System;
using System.Collections.Generic;
using System.Linq;
namespace UnitTest
{
    /// <summary>
    /// 筛选
    /// </summary>
    public static class WordSegement
    { 
        /// <summary>
        /// 根据词性
        /// </summary>
        /// <param name="text"></param>
        public static void Pick(string text)
        {
            //JiebaSegmenter seg = new JiebaSegmenter();
            //var analyser = new JiebaNet.Analyser.TextRankExtractor();
            ////   analyser.ExtractTags("adsf", 2);
           
            var posSeg = new PosSegmenter();  
            var tokens = posSeg.Cut(text);

            Console.WriteLine(string.Join(Environment.NewLine, tokens.Select(token => string.Format("{0}:{1}", token.Word, token.Flag))));

            //var segmenter = new JiebaSegmenter(); 
            // var token2  = segmenter.Tokenize(asdf, TokenizerMode.Default); 
            //foreach (var t in token2)
            //{
            //    Console.WriteLine("{0}: {0,-12} start: {1,-3} end: {2,-3}", t.Word, t.StartIndex,t.EndIndex);
            //}

            //  var analyser = new JiebaNet.Analyser.TextRankExtractor();
            var analyser = new JiebaNet.Analyser.TextRankExtractor();
            var pos = new List<string>() { "n", "v" };
            var list = analyser.ExtractTagsWithWeight(text, 20, pos);
            Console.WriteLine(Environment.NewLine);
            foreach (var t in list)
            {
                Console.WriteLine(t.ToString());
            }
        }

    }
}
