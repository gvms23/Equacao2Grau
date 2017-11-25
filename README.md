# Equacao2Grau
Saudações!

Desenvolvi esse pequeno software para uma explicação básica sobre equação de segundo grau e os passos para se chegar ao resultado final.

![alt text](https://media.licdn.com/media/AAEAAQAAAAAAAA2qAAAAJGM1NmVmNmI5LTYzMzctNDIxNi04OWYzLTdkYzQ2OGFlNDcxOA.png)


Quando o delta for menor que zero, não haverá raízes reais na equação.
![alt text](https://media.licdn.com/mpr/mpr/AAEAAQAAAAAAAAoZAAAAJGU3ZmQzY2YzLWE2OWEtNDkzNS1iM2E2LTBjYjY0ODhmMjkwMQ.png)



Trechos do Código

Dentro dos 3 TextBoxes que receberão A, B e C coloquei o seguinte código:

           //não permitir algumas coisas 
            if (char.IsLetter(e.KeyChar) || //Letras

                char.IsSymbol(e.KeyChar) || //Símbolos

                char.IsWhiteSpace(e.KeyChar)) //Espaço

                e.Handled = true; //Não permitir

            //só permitir digitar uma vez o traço para
﻿            //números negativos
            if (e.KeyChar == '-'
                && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
Trabalhei com métodos específicos do próprio C# para executar a raiz quadrada do delta:

//Math está dentro da biblioteca using System;
Math.Sqrt(delta);

x = (-b + -Math.Sqrt(delta)) / (2 * a);

Utilizei métodos nativos de conversão de dados:

 double a, b, c; 

﻿ a = Convert.ToDouble(txtA.Text);
 b = Convert.ToDouble(txtB.Text);
 c = Convert.ToDouble(txtC.Text);

//pois vale lembrar que todos os TextBoxes têm seus dados do tipo String.
Executei algumas validações caso receba valores nulos ou zeros no A, B e C:

//se encontrar pontos nos textboxes
﻿if (txtA.Text.Contains(".") || txtB.Text.Contains(".") || txtC.Text.Contains("."))
{
     MessageBox.Show("Retire os pontos e substitua-os por vírgula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
     return;
}

//se for vazio
if (txtA.Text == string.Empty || txtB.Text == string.Empty || txtC.Text == string.Empty)
{
     MessageBox.Show("A, B e C não podem estar vazios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
     return;
}
Também foi desenvolvida uma função para truncamento de números com casas decimais:

public decimal TruncateDecimal(decimal valor, int precisao)
{
     decimal step = (decimal)Math.Pow(10, precisao);
     int tmp = (int)Math.Truncate(step * valor);
     return tmp/step;
}

//Utilização:
//Convert.ToDecimal(variavel), 2)
﻿
﻿//exemplo:
double xb;
xb = ((-b - deltaConvert)) / (2 * a);
xb = Convert.ToDouble(TruncateDecimal(Convert.ToDecimal(xb), 2));

/*
﻿Um número truncado com Math.Truncate iria ficar assim:
2,3549798 ﻿=> 2 (ou seja, íamos perder propriedades importantes que vêm
após a vírgula﻿).

Mas com essa belíssima função, ele deixa assim:
﻿﻿2,3549798 => 2,35 pois a precisão que coloquei foi 2, se eu tivesse
colocado 3, ficaria 2,354 e assim por diante.
*/﻿
﻿
 
Vídeo mostrando execução:
<div align="center">
  <a href="https://www.youtube.com/watch?v=xpbalmxXNAQ target="_blank"><img src="https://img.youtube.com/vi/xpbalmxXNAQ/0.jpg" alt="Equação de 2º Grau - C# (Second Degree Equation - Youtube)"></a>
</div>



