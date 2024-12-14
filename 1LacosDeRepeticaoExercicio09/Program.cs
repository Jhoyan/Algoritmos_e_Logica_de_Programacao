using static System.Console;
using static System.Convert;

int escolaridade = 0;
int sexo = 0;
double idade = 0;
int condicao = 0;
int homens = 0;
int mulheres = 0;
double idadeHomens = 0;
double idadeMulheres = 0;
double mediaHomens = 0;
double mediaMulheres = 0;
double faixaEtaria = 0;
double porcentagemFaixaEtaria = 0;
double idadeNova = 1000;
int ef = 0, em = 0, sup = 0, pos = 0;

do
{
    WriteLine("Qual a idade do candidato? ");
    idade = ToDouble(ReadLine());

    WriteLine("Qual o sexo do candidato? (1 para masculino e 2 para feminino)");
    sexo = ToInt32(ReadLine());
    if (sexo == 1)
    {
        homens++;
        idadeHomens += idade;
        if (idade > 35 && idade < 45)
        {
            faixaEtaria++;
        }
    } else if (sexo == 2)
    {
        mulheres++;
        idadeMulheres += idade;
        if (idade < idadeNova)
        {
            idadeNova = idade;
        }
    }
    
    WriteLine("Qual a escolaridade do candidato? (1 - Ensino fundamental, 2 - Ensino médio, 3 - Ensino superior, 4 - Pós-graduação");
    escolaridade = ToInt32(ReadLine());
    switch(escolaridade)
    {
        case 1:
        ef++;
        break;
        case 2:
        em++;
        break;
        case 3:
        sup++;
        break;
        case 4:
        pos++;
        break;
    }
    WriteLine("Deseja cadastrar outro candidato? Se não, digite 0 ");
    condicao = ToInt32(ReadLine());
}
while (condicao != 0);

porcentagemFaixaEtaria = faixaEtaria * 100 / homens;
mediaHomens = idadeHomens / homens;
mediaMulheres = idadeMulheres / mulheres;

WriteLine($"Temos um total de {mulheres} candidatas mulheres, {homens} candidatos homens, {mediaHomens} é a média de idade entre os homens enquanto {mediaMulheres} é a média de idade entre as mulheres. {porcentagemFaixaEtaria}% dos homens tem entre 35 e 45 anos. A mulher mais nova tem {idadeNova} anos. Enquanto isso temos {ef} candidatos com Ensino Fundamental completo, {em} candidatos com Ensino Médio completo, {sup} com Ensino Supeior e {pos} com Pós-graduação.");