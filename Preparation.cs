using System;
using System.Collections.Generic;


namespace VinterProjekt
{
    public class Preparation
    {
        public void PreparationProcess(List<Ingredients> ingredients)
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                Preparation preparation = new Preparation();

                Console.Write(
                    "Congrats, you have made it through the buying process. We promise it is our freshest produce.\n\nHere is what you bought:\n"
                    );

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(
                    ingredients[i].name
                    );

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Now, it is time for judgement.");

                preparation.PreparationTotalScore(ingredients);
            }

        }

        private void PreparationTotalScore(List<Ingredients> ingredients)
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"       
:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:      

,-_/ ,-.  .   .-,--.  ,---. .-,--.   ,-_/ ,-.  .   .-,--.  .  . 
'  |   |  |   ' |   \ |  -'  `\__    '  |   |  |   ' |   \ |  | 
   |   |  | . , |   / |  ,-'  /         |   |  | . , |   / |  | 
   |   `--^-' `-^--'  `---|  '`--'      |   `--^-' `-^--'  `--| 
/` |                   ,-.|          /` |                  .- | 
`--'                   `-+'          `--'                  `--' 
:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.:._.: 
                        ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                "Hello aspiring cook. I understand you want to become a real chef,"
                + "\n but in order to succeed you have to impress me ( ..•˘___˘• .. )"
                + "\n\n Hmm it smells for sure, but let's actually taste it.\n\n"
            );

            for (var e = 0; e < ingredients.Count; e++)
            {
                Console.WriteLine(
                    ingredients[e].name
                );
            }

            int totalCost = 0;
            int totalScore = 0;

            for (int i = 0; i < ingredients.Count; i++)
            {
                totalCost += ingredients[i].price;
                totalScore += ingredients[i].score;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nHmm, the score of this dish will be ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(
                totalScore
            );

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", for the price of ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(
                totalCost
            );

            Console.Write("$");

            Console.ForegroundColor = ConsoleColor.White;

            if (totalScore < 3000 && totalScore > 2500)
            {
                Console.Write(
                    "\n\nI can't say much about this dish, pretty plain and boring."
                    + "\nYou will not become a master chef with this bullshit."
                    + "\nMake me something edible next time."
                );
            }

            else if (totalScore < 4000 && totalScore > 3000)
            {
                Console.Write(
                    "\n\nNothing special. Do I like it? I mean, basic doesn't"
                    + "\nimpress me so you will have to try again."
                );
            }

            else if (totalScore < 4385 && totalScore > 4000)
            {
                Console.Write(
                    "\n\nNow THIS is what i call a real dish. The flavour, I LOVE IT"
                    + "\nEhm... Would... You... Like to marry me?? <3"
                );
            }

            else if (totalScore < 2500 && totalScore > 0)
            {
                Console.Write(
                    "\n\nHELL NAH! You expect me to eat that??? WTF! Don't even try again."
                );
            }

            else if (totalScore == 4386)
            {
                Console.Write(
                    @"
.;i;:,,..;i,:...............,,,,,,,,::::::::::::,::;;;;::::,::.,,,,,,:::::::;;:,....,,,,,..,,,,,,,,,
.,..,..,ifLt,........,:;;,,.,,,,,::,::::::::,,,::;i1iiiii1i;;:,,,,,:;::;::;;:::, ....,,,,..,,,,,,,,,
,..,..,,,i:;,.....,;i1t1i;,.,,,,,,,,,,::::::;i1tt1tt1i::;;;1iii:::;;;;;;:,,,:;:.... .,,,,..,,,,,,,,,
ii:,..,,,........,111tt1i1:.,,,,,,,,,,,::;;;1111i;;ii11ii;;i1it1i;;;;;;;,,:,iti.  . .,,,,..,,,,,,,,,
tf;.,,,...,,,,,,,,;t1tt111;,,,,,,,,,:,,;i1iii;;itti;:,,:;;ii1t1iii;;;;;:,,,,,;i;,....,,,,..,,,,,,,,,
:::..,,:;i:,,,,,,,,ittt11ii:.,,,,,,::::;iiii;;;:;:;ii11i;;;i;;;;i11ii;::,.,,,,,.... .,,,,..,,,,,,,,,
,,,:;ittt11:,,,,,,,,1tt1111;,,,,,,,,,::;;,:1111;::;;1tt1i;;:,,::;i1;;;,:.,,,:::,.....,,,,..,,,,,,,,,
,,;ttttt1tt1:,,,,,,,:1t1111i;,,,,,::::;;:,,;i;::;iii11i;:i;,,:;:;1ti;;:,,:,:;;:,....,,,,,..,,,,,,,,,
:::tfttttttti,,,,,,:,:111t1ii,,,:,::::;;i;;:::;;;;ii;::,ii,,:i:,:,;i;;i;::;i;i;:,....,,,,..,,,,,,,,,
::::ttttttt1ti,,,,::,,:tt111i:,,,,,::::::::::;;:;iiii;;:;;::i::;:.,::::;:;;ii;;:,.....,,,..,,,,,,,,,
::::;ftttttttt;,,,::,,,;t111i;,,:,,::::,,,:::::;;ii11ii;;:;ii;i1i,,:::ii;;i;iii:,.....,,,..,,,,,,,,,
:::::ifttttt111:,::,,,,,;1111i:::,,::::,,,::::;11ttti1111iii11ii1:,,:::1i;;iii;:,,....,,,..,,,,,,,,,
::::::iftttt1it1:,,,,,::,i11ii;:,,,:,,,,,:,.:i1ttff11ttt1i1t1111i,.,,,,:;;iii;;:,.,,..,,,..,,,,,,,,:
::::::,ittt1i1tt1:,,,,::,,i111:,,,,::,,,::::1t1ttttii1tfttft1111i..,,,,:::;;iii;:,,,...,,..,,,,,,,,,
::::::::1t11i1ttti,,:::,:,:111;,,,,::,:,::ii1tttt111ii1ffft1iii1i...,::;;:;;:;;;:,,,,..,,..,,,,,,,::
:::::::::1ti1ttt11i::,,,,,,;i1i,,,,,,,,::;;i1ffLf1111ttLLt1111;ii:,,,;;:;:;;;;:::,,,,..,,..,,,,:::::
1:::::::::11tttt1tt;,,:;1fitLLLffttt11ii1iiittfLLLLLLLfLftfft11ft;,:::;:::;;;;;:,,,,,..,,..,,,,,::::
fi:::::::,:ttttt1tt1111111:;i11tffLLLLCt1Lt11tttfLLCLLfffttfLLLf1:::;:::;;:;;;;,,,,,,...,..,,,,:::::
ffi:::::,,,;111iiiii;;:,,,::,,,,,:::::::::,;tttttffLfttLLttfftt1itt11i;;;;;;ii;:,,..,...,..,,,,:::::
ftt;:::::::;;;;;:::::,:::;:i;:::::::,,,,,:,:tttttffLLfttttttt1i:::::;;;;;;;;ii;:,,......,..,,,,,::::
ttft;::,:::::::,,,::::;;;:,;;;;;;;::;i1111ii1tffttfffffffttt1i,.,,,,,,,,,::::i;:........,..,,,,,:,::
ttfft:,,::::::::::;;;::::,.,:;;ii1fC0GfLLfff1tttffft1iiiii111Lt;,,,,,,,,,,,,,,;:,..........,,,,,,,,:
tffffi,:;i;:::;;;;i;:::,,..,,:;iG8880Gtfffft11tttffffttt1111fG00;;:::::::;;:,,;::,...,,.,..,,,,,,,,,
tffft,,:ii;::;;;ii;:::,..,:;;;;18800GGCtttttttttttfffLfft11tLCC8f;;;;:,:;;;:,,;:,...:::,,..,,,,,,,,,
ffft1,,:;i;:;i1i11i:::::;;;;;;;;G@8GCCGC1tttttttttt11tt1t1tfLG08G;;:,.,:::,,,,,:,..,;;:,,..,,,,,,,,,
ffff1.,:;;:;iiiiiii;;;;;:::,,::,;G00GGG0Gttttfttfttt11111fLCGG08t,,,,,::,,,,,,,,,.,::::,,..,,,,,,,,,
fttf1.,:;:;i;;::,::,,,,,,,,,,,,:::C0G00GGCftttttfftttfttLCGGGG0f,,,,,::,,,.,,,,,,,,,,::,,..,,,,,,,,,
ttttt,,:;:;;;:,,,,,,.,,,,,,,,,,::::C00GG0GCffffffffLffLG00GGG0L,::,,,:,,,....,,.,.,:::,,...,,,,,,,,,
:tttt,.:::;;::,,,....,,,,,,,,,,,::::C800CGG0CfLLLLLfLG0GGGG00t:,::,,:,,,.....,..,..,::,....,,,,,,,,,
:;ttt:.::::;:,,.......,,,,,,,,,,,::::t0800880GLLLLfL0888G08G1:::::,,:,,,.....,.......,,,...,,,,,,,,,
:::tt:.,;::::,,,.......,,,,,,,,,,,,::,iL@880G88LffG@8888@0L:,:::,,,,,,,......,,,.......,. .,,,,,,,,,
:,,;t:.:;:;:,,,.,,......,,,,,,,,,,,,::,,1L800Gttff1L8G0Lf;,:::,,,,,,,,,.....,,,,.,......,..,,,,,,,,,
:,:,;,.:;::,,..,,..,....,,,,,,,,,,,,,,::,,;;t;,:t1,,;:;,,,:::,,,,,,,,,,......,,..,..,....,,,,,,,,,,,

                    "
                );
            }

        }

    }
}