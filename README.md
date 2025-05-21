# Documentação do Protótipo Next

## Nome do Sistema e Propósito

**Protótipo Next** é um sistema desenvolvido em C# com Windows Forms e Oracle Database, com o objetivo de gerenciar usuários e clientes. O sistema possui funcionalidades de login, exibição e cadastro de clientes com perfis de investimento.
Regras de Negócio  

- O sistema exige que o usuário realize login com RM e senha válidos cadastrados no banco.  
- Após o login, o nome do usuário é exibido na tela principal.  
- O sistema permite visualizar todos os clientes cadastrados.  
- É possível adicionar a base de dados um novo cliente informando nome e perfil de investimento.
  - Perfis de investimento disponíveis: Agressivo, Moderado e Conservador.
- O sistema mostra informações sobre perfis de investimento

## Descrição das Telas
### Tela de Login

- Inputs: RM, Senha (Ambos TextBox)  
- Ação: Autentica o usuário baseado em usuarios na base de dados.  
- Validação com mensagem em caso de falha em forma de Label.  
- Em caso de sucesso, mostra mensagem e abre a tela do menu.  
- Login cadastrado
  - RM: 551726
  - Senha: 200398

### Tela de Menu Principal

- Menu com as opções (menu strip):  
  - Home (Pagina de abertura)  
  - Ver Clientes  
  - Adicionar Cliente  
  - Informações sobre Perfil 
  - Sair  

#### Home
- Pega o nome de quem fez o login baseado no rm colocado para acessar a aplicação.

#### Tela de Visualização de Clientes
- Exibe uma tabela (DataGridView) com os clientes cadastrados.
- Pega os dados da base de dados.

#### Tela de Adição de Cliente
- Inputs: Nome do Cliente (TextBox) , Perfil (seleção por ComboBox)  
- Botão para confirmar o cadastro.
- Cadastra cliente na base de dados.  

#### Tela de Informações sobre Perfis
- Explicação textual sobre os tipos de perfil de investimento.  

## Oracle Database: Estrutura das Tabelas

### Tabela: Usuarios
| Coluna | Tipo de dado	| Restrições |
| ------ | ------------ | ----------- |
| ID | NUMBER	| PRIMARY KEY |
| RM | NUMBER	| NOT NULL |
| Nome | VARCHAR2(100)	| NOT NULL |
| Senha	| VARCHAR2(10) | NOT NULL |

### Tabela: Clientes
| Coluna | Tipo de dado	| Restrições |
| ------ | ------------ | ----------- |
| ID | NUMBER	| PRIMARY KEY |
| Nome | VARCHAR2(100) | NOT NULL |
| Perfil | VARCHAR2(100) | NOT NULL |

## Diagrama do Fluxo de Arquitetura

**UI Layer:**  
TelaLogin  
TelaMenu  
↓  
**Controller Layer:**  
UsuarioController  
ClienteController  
↓  
**Repository Layer:**  
UsuarioRepository  
ClienteRepository  
↓  
**Database:**  
Oracle Database (Tabelas: Usuarios, Clientes)  

## Tecnologias Utilizadas

- Linguagem: C#, SQL  
- Framework: Windows Forms (.NET Framework)  
- Banco de Dados: Oracle Database  
- IDE: Visual Studio, DBeaver   
- Gerenciamento de Projeto: Git + GitHub  

## Pontos de Melhoria para o 2º Semestre

- Implementar sistema de autenticação com criptografia de senhas.  
- Adicionar validação de campos com mensagens mais descritivas.
- Adicionar visualização de perfil com mais detalhes
- Form para inserir dados sobre o cliente, e então gerar o tipo de perfil correspondente
