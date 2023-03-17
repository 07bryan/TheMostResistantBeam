namespace Strings.Logic
{
    public class TheMostResistantBeam
    {
        private static string _beam = "";

        public TheMostResistantBeam(string text)
        {

            _beam = text;
        }

        public string validBeam()
        {
            int baseInit = getBase();
            int sumTotal = 0;
            int countL = 1;
            string response;
            if(baseInit == 0)
            {
                return "Base no valida";
            }
            for(int i = 0;i < _beam.Length; i++) {
                char currentChar = _beam[i];
                char nextChar = ' ';
                if(i+1 < _beam.Length) {
                    
                    nextChar = _beam[i + 1];
                }
                if(currentChar == '*' & nextChar == '*')
                {
                    return "La viga esta mal construida!";
                }
                if (currentChar == '=') {
                    sumTotal += countL;
                    countL++;
                }
                if(currentChar == '*')
                {
                    sumTotal *= 2;
                    countL = 1;
                }
            }

            if(sumTotal > baseInit)
            {
                response = "La viga NO soporta el peso!";
            }
            else
            {
                response = "La viga soporta el peso!";
            }            

            return response;
        }

        public static int getBase() {
            string firstChard = _beam.Substring(0, 1);
            int valueBase = 0;
            switch (firstChard)
            {
                case "#":
                    valueBase = 90;
                    break;
                case "%":
                    valueBase = 10;
                    break;
                case "&":
                    valueBase = 30;
                    break;
                default: return valueBase;
            }
            return valueBase;
        }

        
    }
}