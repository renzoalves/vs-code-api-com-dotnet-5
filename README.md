# C# com VSCode - Construindo uma API com dotNET.5

## 🗺️ Dividindo em camadas:
- Introdução, apresentando o problema
- Camada de domínio [01:08:17]
- - Linguagem ubíqua e contextos delimitados
- - Entidades e entidade base
- - Modelagem
- - Enumeradores e value objects
- - Validações das entidades
- - Domain Notifications
- Camada de aplicação
- Camada de infraestrutura
- Modelando o banco de dados
- Criando a API
- Ajustando os detalhes
- Aplicando boas práticas
- Resolução e Review

## 📟 Case Study: Control of Vaccines for Pet Shop - Solicitação do cliente:
- Aplicação para controle de vacinação de animais;
- Precisa ter descrição da vacina;
- Cadastro de donos;
- Cadastro e controle de pets;
- Um dono pode ter vários pets;
- As vacinas devem ser separadas por grupos e devem ter um controle e cadastro;

## 💡Info
- Projeto possui validador de CPF;
- Projeto possui validador de CNPJ;

## 🎞️ Série de vídeos - Central dotNET <br>(https://www.youtube.com/@CentraldotNET)

<details>
<summary> 📗 Camada de Domínio </summary>
<br>

01 - Introdução e apresentação do problema (API com dotNET-5) [5:09]<br>
https://www.youtube.com/watch?v=VEEw-X3sYGg

02 - Domínio - Linguagem Ubíqua e Contextos Delimitados(API com dotnet5) [4:16]<br>
https://www.youtube.com/watch?v=wRwM2MVzHrw

03 - Criando o projeto [2:09]<br>
https://www.youtube.com/watch?v=2NbHSCyzeoY

04 - Domínio - Entidades e entidade abstrata [6:30]<br>
https://www.youtube.com/watch?v=-w6BK0BKPWo

05 - Domínio - Modelando as entidades [8:45]<br>
https://www.youtube.com/watch?v=T53hRmYXl_E

06 - Domínio - Enums e Value Objects [7:04]<br>
https://www.youtube.com/watch?v=7JoWaR-qmCA

07 - Domínio - Validações das entidades [7:50]<br>
https://www.youtube.com/watch?v=olkVSiFE6qE

08 - Domínio - Contratos e Notificações (Contracts e Notifications) [7:27]<br>
https://www.youtube.com/watch?v=vDU-a0UqATI

09 - Domínio - Unindo os contratos, validações e notificações [20:07]<br>
https://www.youtube.com/watch?v=Uy2A-BwUqX4

</details>

<details>
<summary>📘 Camada de Testes Unitários </summary>
<br>
01 <br>
02 <br>

</details>

<details>
<summary>📙 Camada de Aplicação </summary>
<br>

01 <br>
02 <br>
03 <br>
04 <br>
05 <br>
06 <br>

</details>

<details>
<summary>📕 Camada de Infraestrutura </summary>
<br>
</details>


<br><br><br><br>

# Comandos dotNET.5

Estrutura de modelo:<br>
<pre>
..\Pets
..\Pets\Pets.Domain
..\Pets\Pets.Domain\Pets.Domain.csproj
..\Pets\Pets.Tests
..\Pets\Pets.Tests\Pets.Tests.csproj
</pre>
<br>

## Testes de Unidades com 'MSTest'.

- Criando um projeto de testes:
<pre>
c:\projeto\Pets> mkdir Pets.Tests
c:\projeto\Pets> cd Pets.Tests
c:\projeto\Pets\Pets.Tests> dotnet new mstest --framework net5.0
</pre>

## Solution

- Criando uma solution:
<pre>c:\projeto\Pets> dotnet new sln</pre>

- Adicionando projetos à solution:
<pre>
c:\projeto\Pets> dotnet sln add Pets.Domain
c:\projeto\Pets> dotnet sln add Pets.Tests
</pre>

- Buildando a solução:
<pre>c:\projeto\Pets> dotnet build</pre>

- No prtojeto 'Pets.Tests', adicionando a Referência do Pets.Domain
<pre>
c:\projeto\Pets> cd Pets.Tests
c:\projeto\Pets\Pets.Tests> dotnet add reference ..\Pets.Domain\Pets.Domain.csproj
</pre>

- Executando os testes automático:
<pre>c:\projeto\Pets\Pets.Tests> dotnet test</pre>
