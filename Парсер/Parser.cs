using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Парсер
{
    
    class Parser
    {
        enum Types { NONE, DELIMITER, VARIABLE, NUMBER };
        enum Errors { SYNTAX, UNBALPARENS, NOEXP, DIVBYZERO };
        public bool ERROR=false;

        string exp;
        int expIdx;
        string token;
        Types tokType;

        public double Evaluate(string expstr)
        {
            double result;
            exp = expstr;
            expIdx = 0;
            GetToken();
                if (token == "")
                {
                    SyntaxErr(Errors.NOEXP);
                    return 0.0;
                }

                EvalExp2(out result);

                if (token != "")
                    SyntaxErr(Errors.SYNTAX);
                return result;
        }

        void EvalExp2(out double result)
        {
            string op;
            double partialResult;
            EvalExp3(out result);
            while ((op = token) == "+" || op == "-")
            {
                GetToken();
                EvalExp3(out partialResult);
                switch (op)
                {
                    case "-":
                        result = result - partialResult;
                        break;
                    case "+":
                        result = result + partialResult;
                        break;
                }
            }
        }

        void EvalExp3(out double result)
        {
            string op;
            double partialResult = 0.0;

            EvalExp4(out result);
            while ((op = token) == "*" || op == "/" || op == "%")
            {
                GetToken();
                EvalExp4(out partialResult);
                switch (op)
                {
                    case "*":
                        result = result * partialResult;
                        break;
                    case "/":
                        result = result / partialResult;
                        break;
                    case "%":
                        if (partialResult == 0.0)
                            SyntaxErr(Errors.DIVBYZERO);
                        result = (int)result % (int)partialResult;
                        break;
                }
            }
        }

        void EvalExp4(out double result)
        {
            double partialResult, ex;
            int t;
            EvalExp5(out result);
            if (token == "^")
            {
                GetToken();
                EvalExp4(out partialResult);
                ex = result;
                if (partialResult == 0.0)
                {
                    result = 1.0;
                    return;
                }
                for (t = (int)partialResult - 1; t > 0; t--)
                    result = result * (double)ex;
            }
        }

        void EvalExp5(out double result)
        {
            string op = "";
            if ((tokType == Types.DELIMITER) && token == "+" || token == "-")
            {
                op = token;
                GetToken();
            }
            EvalExp6(out result);
            if (op == "-")
                result = -result;
        }

        void EvalExp6(out double result)
        {
            if ((token == "("))
            {
                GetToken();
                EvalExp2(out result);
                if (token != ")")
                    SyntaxErr(Errors.UNBALPARENS);
                GetToken();
            }
            else Atom(out result);
        }

        void Atom(out double result)
        {
            switch (tokType)
            {
                case Types.NUMBER:
                    try
                    {
                        result = Double.Parse(token);
                    }
                    catch (FormatException)
                    {
                        result = 0.0;
                        SyntaxErr(Errors.SYNTAX);
                    }
                    GetToken();
                    return;
                default:
                    result = 0.0;
                    SyntaxErr(Errors.SYNTAX);
                    break;
            }
        }

        void SyntaxErr(Errors error)
        {
            Form1 a = new Form1();
            switch (error)
            {
                case Errors.SYNTAX:
                    a.ShowError(0);
                    break;
                case Errors.UNBALPARENS:
                    a.ShowError(1);
                    break;
                case Errors.NOEXP:
                    a.ShowError(2);
                    break;
                case Errors.DIVBYZERO:
                    a.ShowError(3);
                    break;
            }
            ERROR = true;
        }

        void GetToken()
        {
            tokType = Types.NONE;
            token = "";

            if (expIdx == exp.Length) return;

            while (expIdx < exp.Length && Char.IsWhiteSpace(exp[expIdx]))
                ++expIdx;

            if (expIdx == exp.Length) return;

            if (IsDelim(exp[expIdx]))
            {
                token += exp[expIdx];
                expIdx++;
                tokType = Types.DELIMITER;
            }
            else if (Char.IsLetter(exp[expIdx]))
            {
                while (!IsDelim(exp[expIdx]))
                {
                    token += exp[expIdx];
                    expIdx++;
                    if (expIdx >= exp.Length) break;
                }
                tokType = Types.VARIABLE;
            }
            else if (Char.IsDigit(exp[expIdx]))
            {
                while (!IsDelim(exp[expIdx]))
                {
                    token += exp[expIdx];
                    expIdx++;
                    if (expIdx >= exp.Length) break;
                }
                tokType = Types.NUMBER;
            }
        }

        bool IsDelim(char c)
        {
            if (("+-/*%^=()".IndexOf(c) != -1))
                return true;
            return false;
        }
    }
}
