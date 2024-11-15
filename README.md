# Sistema de Gerenciamento de Biblioteca

## 1. Introdução

**Apresentação do Projeto**  
Este projeto consiste no desenvolvimento de um sistema de gerenciamento de biblioteca com funcionalidades que abrangem o cadastro de livros, autores, usuários, gerenciamento de empréstimos e devoluções, além de consultas diversas. O projeto foi criado para demonstrar a aplicação prática dos conhecimentos de modelagem de dados, criação e manipulação de tabelas, operações de manipulação de dados e o uso de joins no banco de dados.

**Objetivos**  
- Demonstrar habilidades em modelagem e manipulação de dados.
- Utilizar operações como criação de tabelas, inserção, atualização e exclusão de dados.
- Implementar consultas que façam uso de joins para relacionar informações.

## 2. Requisitos do Projeto

### Requisitos Funcionais
1. **Cadastro de Usuários**
   - Inclusão de novos usuários.
   - Atualização de informações dos usuários.
   - Exclusão de usuários do sistema.
   - Consulta de informações dos usuários.

2. **Cadastro de Livros e Autores**
   - Inclusão de novos livros.
   - Atualização de informações dos livros.
   - Exclusão de livros do sistema.
   - Consulta de informações dos livros e autores.

3. **Gerenciamento de Empréstimos**
   - Registro de novos empréstimos.
   - Registro de devoluções de livros.
   - Consulta de histórico de empréstimos por usuário e por livro.

4. **Consultas**
   - Listagem de todos os livros disponíveis.
   - Listagem de livros atualmente emprestados.

## 3. Estrutura do Trabalho Final

### 1. Implementação do Banco de Dados
   - Criação das tabelas para armazenar as informações de usuários, livros, autores e empréstimos.
   - Inserção de dados iniciais para teste e uso do sistema.
   - Operações de manipulação de dados, como atualização e exclusão.

### 2. Manipulação de Dados
   - Realização de operações básicas (inserções, atualizações, exclusões) no banco de dados.
   - Consultas para obtenção de informações específicas e relatórios.

### 3. Utilização de Joins
   - Implementação de consultas com `LEFT JOIN`, `RIGHT JOIN`, entre outros tipos de joins, para relacionar tabelas e extrair dados que atendam aos requisitos de consulta do sistema.

## 4. Tecnologias Utilizadas
- Linguagem: C# para a interface de usuário.
- Banco de Dados: MySQL para armazenamento e gerenciamento dos dados.
- Ferramentas: Visual Studio para desenvolvimento e MySQL Workbench para gerenciamento do banco de dados.

## 5. Como Executar o Projeto
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git

2. Configure a string de conexão do banco de dados em Database.cs com suas credenciais do MySQL.
3. Compile e execute o projeto usando Visual Studio.
4. Verifique se as tabelas estão criadas no banco de dados, e execute as inserções iniciais, se necessário.

## 6. Contribuição
- Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

## 7. Licença
- Este projeto é licenciado sob a licença MIT. Consulte o arquivo LICENSE para mais informações.

## 8. Contato
- Para dúvidas ou sugestões, entre em contato:

- **Nome: Renan Santos de Oliveira**
- **E-mail: seu-email@example.com**
- **LinkedIn: https://www.linkedin.com/in/renanodev/**