// Cria um construtor para a aplicação web, configurando o ambiente e recebendo argumentos da linha de comando (args)
var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários para usar Razor Pages no container de injeção de dependência
builder.Services.AddRazorPages();

// Constrói o objeto 'app' que representa a aplicação web configurada
var app = builder.Build();

// Configura o pipeline de requisição HTTP — define como a aplicação responde às requisições
if (!app.Environment.IsDevelopment())  // Se NÃO estiver em ambiente de desenvolvimento (ex: produção)
{
    // Define a página de erro personalizada que será exibida em caso de exceção
    app.UseExceptionHandler("/Error");

    // Habilita HTTP Strict Transport Security (HSTS), que força o uso de HTTPS no navegador por 30 dias
    app.UseHsts();
}

// Redireciona todas as requisições HTTP para HTTPS, garantindo segurança
app.UseHttpsRedirection();

// Permite que a aplicação sirva arquivos estáticos (CSS, JS, imagens) da pasta wwwroot
app.UseStaticFiles();

// Adiciona o middleware de roteamento, que identifica a rota da requisição e direciona para o endpoint correto
app.UseRouting();

// Adiciona o middleware de autorização para verificar permissões de acesso (mesmo que não tenha nenhuma configuração específica)
app.UseAuthorization();

// Mapeia as páginas Razor para que as rotas definidas nas páginas funcionem
app.MapRazorPages();

// Executa a aplicação, iniciando o servidor web para escutar requisições
app.Run();
