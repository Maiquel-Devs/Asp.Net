var builder = WebApplication.CreateBuilder(args);
// Cria o construtor da aplicação ASP.NET Core (configura servidor, logs e serviços).

builder.Services.AddRazorPages();
// Adiciona o suporte para Razor Pages (páginas .cshtml com C#).

var app = builder.Build();
// Monta a aplicação com as configurações definidas acima.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // Define uma página de erro personalizada (Error.cshtml) quando o app não está em modo de desenvolvimento.

    app.UseHsts();
    // Ativa o HSTS (segurança que força o uso de HTTPS nos navegadores).
}

app.UseHttpsRedirection();
// Redireciona automaticamente requisições HTTP para HTTPS.

app.UseStaticFiles();
// Permite o uso de arquivos estáticos (CSS, JS, imagens) da pasta wwwroot.

app.UseRouting();
// Ativa o sistema de rotas (controla para onde cada URL vai).

app.UseAuthorization();
// Habilita a verificação de permissões e acesso de usuários (caso seja usada).

app.MapRazorPages();
// Conecta todas as Razor Pages (.cshtml) às suas rotas para funcionar no navegador.

app.Run();
// Inicia o servidor web e mantém o site em execução.
