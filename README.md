MPRJ Inova API - Readme

Descrição

API de exemplo, desenvolvida como parte do processo seletivo para o MPRJ Inova. Esta API em NET Core fornece acesso a quatro endpoints principais para consultas diversas, incluindo consulta de CEP, consulta de corretoras, consulta de corretoras por CNPJ e consulta de feriados.

Ferramentas e versões utilizadas

Desenvolvida em Net Core versão 6.0

Instalação

    1. É necessário instalar o sdk .NET 6.0 ou superior.
	2. Baixar o projeto em sua máquina.

Comandos para execução local

    1. Abrir o terminal dentro da pasta do projeto.
	2. Executar o comando "dotnet run"
    3. Ao executar abrir no navegador a url = "https://localhost:7053/swagger/index.html"
	4. No Swagger clickar no endpoint desejado, logo em seguida clickar em "try it out", Caso tenha algum parametro passe-o no barra de entrada e depois so clickar em execute, os dados serão retornados em JSON.
Endpoints Disponíveis

1. Consulta de CEP

	•	Endpoint: /api/v1/Cep/buscar/{cep}
	•	Método: GET
	•	Descrição: Retorna informações relacionadas ao CEP fornecido, incluindo detalhes sobre o endereço.

2. Consulta de Corretoras

	•	Endpoint: /api/v1/Corretora/buscar
	•	Método: GET
	•	Descrição: Retorna uma lista de corretoras disponíveis, fornecendo informações básicas sobre cada uma.

3. Consulta de Corretoras por CNPJ

	•	Endpoint: /api/v1/Corretora/buscar/{cnpj}
	•	Método: GET
	•	Descrição: Fornece informações detalhadas sobre uma corretora específica, identificada pelo seu CNPJ.

4. Consulta de Feriados

	•	Endpoint: /api/v1/Feriado/buscar/{ano}
	•	Método: GET
	•	Descrição: Retorna uma lista dos próximos feriados, oferecendo detalhes sobre cada data comemorativa.

Exemplos de Uso

Consulta de CEP

curl -X GET "https://localhost:7053/api/v1/Cep/buscar/{cep}" 

Consulta de Corretoras

curl -X GET "https://localhost:7053/api/v1/Corretora/buscar"

Consulta de Corretoras por CNPJ

curl -X GET "https://localhost:7053/api/v1/Corretora/buscar/{cnpj}"

Consulta de Feriados

curl -X GET "https://localhost:7053/api/v1/Feriado/buscar/{ano}" 



Considerações Finais

A API MPRJ Inova é uma ferramenta poderosa para obter informações relevantes.

