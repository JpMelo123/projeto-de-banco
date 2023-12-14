<div align=center> <h1>Sistema Bancário</h1></div>

## Status Do Projeto 

Em Desenvolvimento 

## Introdução

O sistema é voltado para o atendimento ao cliente de uma instituição financeira, onde são registrados dados do cliente, como nome, data de nascimento e documentos. Essas informações são posteriormente utilizadas na consuta do usuário. O cliente também escolhe o tipo de transação que deseja como: depósito e saque.

## Linguagem Utilizada

Todo o projeto foi desenvolvimento em C#

## Sobre o Código

### Classe Abstrata: CadastroAbs

A classe CadastroAbs é declarado como classe abstrata por isso não pode ser instanciada diretamente,essa classe só serve como base para outras classes.

#### Atributos: 

nome (string) - é utilizado para armazenar o nome do usuário.

Cpf (string) - é utilizado para armazenar o cpf do usuário.

DataNasc (string) - é utilizado para armazenar a data de nascimento do usuário.

Senha (string) - é utilizado para armazenar a senha do usuário.

escolha(double) - é utilizado para o usuário escolher entre o login ou finalizar o programa.

escolha2(double) - é utilizado para o usuário escolher entre o saque ou depósito.

Saldo (double) - é utilizado para visualizar o saldo do usuário.

Deposito (double) - é utilizado para o usuário acrescentar valores ao seu saldo.

Saque (double) - é utilizado para o usuário saquar valores do seu saldo.

SaldoTotal (double) - é utilizado para visualizar o valor total do saldo do usuário.

#### Métodos:

ReceberDados(abstract) - método abstrato que deve ser usado por classes derivadas,serve para mostrar as informaçoes do CadastroAbs para confirmação.

### Classe: Cadastro (Herda de CadastroAbs)

A classe Cadastro herda todos os atributos e métodos da classe abstrata CadastroAbs.

#### Métodos:

ReceberDados(override) - Método sobrescrito da classe base CadastroAbs, ele serve para mostrar na tela todas as informações sobre o cadastro para confirmação destes dados.

introducao() - método escrito da classe cadastro, ele serve para mostrar na tela o menu inicial.

Entrar() - método escrito da classe cadastro, ele serve para acessar o programa, caso o usuário não tenha efetuado o cadastro ele retornará para a tela inicial de cadastro.

retorno() - método escrito da classe cadastro, ele direciona o usuário para a opção de depósito e/ou saque.

## Requisitos Funcionais 

Requisitos funcionais, são especificações detalhadas das funcionalidades que um sistema ou software deve oferecer. Eles descrevem as ações específicas que o sistema deve executar em resposta a entradas específicas do usuário ou de outros sistemas. Esses requisitos definem o que o sistema deve fazer para atender às necessidades e expectativas dos usuários.

<table>
<tr>
<td>Número</td>
<td>Nome</td>
<td>Descrição</td>
</tr>
<tr>
<td>RF01</td>
<td>Cadastro de Usuário</td>
<td> O sistema permite o cadastro de informações sobre uma pessoa, incluindo nome, data de nascimento e documento</td>
</tr>
<tr>
<td>RF02</td>
<td>Login</td>
<td>O usuário precisa fazer o login para ter acesso ao sistema</td>
</tr>
<tr>
<td>RF03</td>
<td>Escolha de Serviços</td>
<td>O usuário pode optar por serviços, como depósito e saque</td>
</tr>
<tr>
<td>RF04</td>
<td>Confirmação de Informações</td>
<td>O sistema exibe as informações inseridas e solicita confirmação do usuário</td>
</tr>
</table>

## Requisitos Não Funcionais

Requisitos não funcionais referem-se à características do sistema que não estão relacionadas diretamente às funcionalidades específicas, mas sim a atributos que impactam seu desempenho, usabilidade, segurança, entre outros. Exemplos incluem requisitos de desempenho, como tempo de resposta, requisitos de segurança, como controle de acesso, e requisitos de usabilidade, como a interface do usuário. Esses requisitos abordam aspectos globais do sistema, garantindo que ele atenda a critérios além das funcionalidades específicas.

<table>
<tr>
<td>Número</td>
<td>Nome</td>
<td>Descrição</td>
</tr>
<tr>
<td>RNF01</td>
<td>Interface de Console</td>
<td>O sistema utiliza uma interface de console para interação com o usuário</td>
</tr>
<tr>
<td>RNF02</td>
<td>Validação de Entrada</td>
<td>O sistema valida as entradas do usuário, garantindo que campos obrigatórios não fiquem vazios e que as escolhas sejam válidas</td>
</tr>
<tr>
<td>RNF03</td>
<td>Tratamento de Exceções</td>
<td>O código inclui tratamento de exceções para lidar com possíveis erros durante a execução</td>
</tr>
<tr>
<td>RNF04</td>
<td>Multiplataforma</td>
<td>O código pode ser executado em qualquer plataforma que suporte a execução de aplicativos .NET</td>
</tr>
<tr>
<td>RNF05</td>
<td>Eficiência</td>
<td>O código busca eficiência ao realizar cálculos e processos</td>
</tr>
</table>
