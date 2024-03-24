Implementação

* Utilizei a Clean Architecture nesse projeto mas dependendo do contexto poderiamos pensar em uma arquitetura Hexagonal para utilização de processos assincronos com microserviços. 
* Realizada implementação sem utilização de banco de dados pois não possuo uma instancia do SQL Server para utilização nesse momento, realizei a criação de lista em memória para simular todas as operações que seriam feitas em banco de dados.
* Como não estou utilizando banco de dados não me preocupei com o vinculo entre os objetos Cliente x Logradouro, caso estivesse utilizando o banco teria os Ids dos objetos para garantir a integridade dos dados.
* Como solução para esse desafio eu utilizaria o Entity Framework Core por ser uma aplicação mais simples e sem muita regra de negocio o que aumentaria a produtividade na construção das classes de repositório.
* Em relação ao logotipo eu coloquei uma propriedade aguardando um base64 pois não considero uma boa prática realizar o salvamento de IMAGE no SQL Server, sei que é possível no front-end transformar um binário em Base64 mas como solução definitiva eu receberia o MemoryStream do arquivo e salvaria no S3, informando apenas a referencia do arquivo na coluna Logradouro.
* Em relação a performance considero que dado a cenário de um número massivo de requisições talvez a utilização do DynamoDB ou MongoDB para armazenar essas informações faria mais sentido, outra solução seria a utilização de Kafka para trabalharmos nessas inserções de maneira assincrona.
* Não realizei a implementação da autenticação/autorização por falta de tempo mas nesse cenário a utilização de um JWT atenderia a demanda, eu criaria uma rota para receber username/password e devolveria um token para utilização nas rotas Cliente e Logradouro, essas rotas teriam a tag [Authorize] ou [Authorize(Roles = "Admin")] caso fosse necessário trabalhar com roles. Também seria possível utilizar ferramentas como o KeyClock para administrar essas credenciais e remover a necessidade de aplicação cuidar dessa parte.
* Seria de extrema importante implementar testes unitários e integrados na aplicação primeiramente para testar os métodos de serviço que criei e também realizar testes integrados disparando requisições diretamente para as rotas das controllers, aqui se faz necessário a utilização de Mock para simular os comportamentos independente da massa de dados envolvida.

Testes

* Baixar o projeto no GIT e executar diretamente no VS2022, através das rotas do Swagger é possível realizar todas as ações demonstradas.
* Em casos de dúvidas fico a disposição.
