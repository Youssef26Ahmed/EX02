using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class TrueOrFalse : Question
    {
        public TrueOrFalse(string header, string body, int mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {
        }

    }
}
