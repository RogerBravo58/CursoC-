using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // FUNDAMENTOS
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar },
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos",  Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadoes Unários - Fundamentos", OperadoesUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                // ESTRUTURAS DE CONTROLE
                {"Estruturas IF - Estruturas De Controle", EstruturaIF.Executar},
                {"Estrutura If/Else - Estruturas De Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/IF - Estruturas De Controle", EstruturaIfElseIF.Executar},
                {"Estrutura Switch - Estruturas De Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas De Controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile - Estruturas De Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas De Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas De Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas De Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas De Controle", UsandoContinue.Executar},
                
                // ESTRUTURAS DE CONTROLE
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Ser - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro Com Valor Padrao - Classes e Métodos", ParametroPadrao.Executar},

                //COLEÇÕES
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //ORIENTAÇÃO OBJETO
                {"Heranca - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                 //Metodos e Funcoes
                 {"Exemplo Lambda - Metodos e Funcoes", ExemploLambda.Executar},
                 {"Lambdas Como Delegates - Metodos e Funcoes", LambdasDelegate.Executar},
                 {"Usando Delegates - Metodos e Funcoes", UsandoDelegates.Executar},
                 {"Delegate Com Função Anonima - Metodos e Funcoes", DelegateFunAnonima.Executar},
                 {"Delegate Como Parametro - Metodos e Funcoes", DelegateComoParametro.Executar},
                 {"Metodos De Extensao - Metodos e Funcoes", MetodosDeExtensao.Executar},
                 
                 //Exceções
                 {"Primeira Exceçao - Exceções", PrimeiraExcecao.Executar},
                 {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                 
                 //API
                 {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                 {"Lendo Arquivos - Usando API", LendoArquivos.Executar},
                 {"Exemplo File Info - Usando API", ExemploFileInfo.Executar},
                 {"Diretorios - Usando API", Diretorios.Executar},
                 {"Exemplo Directory Info - Usando API", ExemploDirectoryInfo.Executar},
                 {"Exemplo Path - Usando API", ExemploPath.Executar},
                 {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                 {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},

                 //Tópicos Avançados
                 {"LINQ #01 - Tópicos Avançados", LINQ1.Executar},
                 {"LINQ #02 - Tópicos Avançados", LINQ2.Executar},
                 {"Nullables - Tópicos Avançados", Nullables.Executar},
                 {"Dynamics - Tópicos Avançados", Dynamics.Executar},
                 {"Genericos - Tópicos Avançados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}