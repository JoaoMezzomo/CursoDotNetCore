using System;
using System.Collections.Generic;
using CursoDotNetCore.Fundamentos;
using CursoDotNetCore.EstruturaDeControle;
using CursoDotNetCore.ClassesEMetodos;
using CursoDotNetCore.Colecoes;
using CursoDotNetCore.OO;
using CursoDotNetCore.MetodosEFuncoes;
using CursoDotNetCore.Excecoes;
using CursoDotNetCore.API;
using CursoDotNetCore.TopicosAvancados;

namespace CursoDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Read Only - Classes e Métodos", ReadOnly.Executar},
                {"Exemplos Com Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct VS Classe - Classes e Métodos", StructVSClasse.Executar},
                {"Valor VS Referência - Classes e Métodos", ValorVSReferencia.Executar},
                {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro Padrão - Classes e Métodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"ArraySet - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstração - Orientação a Objetos", Abstrata.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                //Métodos e Funções
                {"Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambda com Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate Func Anonima - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegate com Parâmetros - Métodos e Funções", DelegatesComParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},

                //API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - API", LendoArquivos.Executar},
                {"File Info - API", ExemploFileInfo.Executar},
                {"Diretórios - API", Diretorios.Executar},
                {"Directory Info - API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - API", ExemploPath.Executar},
                {"Exemplo DateTime - API", ExemploDateTime.Executar},
                {"Exemplo Time Span - API", ExemploTimeSpan.Executar},

                //Tópicos Avançados
                {"LINQ1 - Tópicos Avançados", LINQ1.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
            });

            central.SelecionarEExecutar();
        }

    }
}
