// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Digite o seu nome");
// var nome = Console.ReadLine();

// Console.WriteLine($"Olá, {nome} ");

// var umaString = "Essa é uma string";
// var numeroInt = 5;
// var numeroFloat = 5.4f;
// var numeroDouble = 5.4;
// var numeroDecimal = 5.3m;
// var array = new int[3] { 1, 2, 3 };
// var caractere = 'a';
// var date = new DateTime(1997, 2, 6);

// Console.WriteLine("Digite uma opção de 1 a 3");
// var opcao = Console.ReadLine();

// if (opcao == "1"){
//   Console.WriteLine("Você entrou no menu de Cadastro.");
//   } else if(opcao == "2") {
//     Console.WriteLine("Você entrou no menu de reclamação.");
//   } else if(opcao == "3") {
//     Console.WriteLine("Você entrou no menu de atendimento de suporte.");
//   } else {
//       Console.WriteLine("Opção invalida");
//   }

//   switch(opcao) {
//     case "1":
//       Console.WriteLine("Você entrou no menu de Cadastro.");
//     break;
//     case "2": 
//       Console.WriteLine("Você entrou no menu de reclamação.");
//     break;
//     case "3": 
//       Console.WriteLine("Você entrou no menu de atendimento de suporte.");
//     break;
//     default:
//       Console.WriteLine("Opção invalida");
//     break;
//   }


  // var valores = Console.ReadLine(); // 1 2 3 4 5
  // var valoresArray = valores.Split(" ");

  // for (var i = 0; i < valoresArray.Length; i++) {
  //   Console.Write(valoresArray[i] + " ");
  // }

  // Console.WriteLine();

  // var contador = 0;

  // while(contador < valoresArray.Length) {
  //   Console.Write(valoresArray[contador] + " ");
    
  //   contador++;
  // }

  // Console.WriteLine();

  // foreach ( var item in valoresArray) {
  //   Console.Write(item + " ");
  // }


  // var notas = new List<int> { 10, 5, 3, 2, 10, 4, 5, 6, 8, 2 };

  // var anyNota1 = notas.Any(n => n == 1);
  // var firstNota10 = notas.First(n => n == 10);
  // var singleNota8 = notas.Single( n => n == 8);
  // var orderNotas = notas.OrderBy(n => n);
  // var max = notas.Max();
  // var min = notas.Min();
  // var sum = notas.Sum();
  // var average = notas.Average();

  // Console.WriteLine($"Max: {max}");
  // Console.WriteLine($"Min: {min}");
  // Console.WriteLine($"Sum: {sum}");
  // Console.WriteLine($"Average: {average}");

  // foreach (var nota in orderNotas) {
  //   Console.Write(nota + " ");
  // }

var pacotes = new List<Pacote>();

Console.WriteLine("-------Servico de postagem");

ExibirMensagemPrincipal();

var opcao = Console.ReadLine();
while (opcao != "0") {
  switch (opcao) {
    case "1":
      var pacote = CadastrarPacote();
      pacotes.Add(pacote);
      break;
    case "2":
      //AtualizarPacote();
      break;
    case "3":
      //ConsultarPacote();
      break;
    default: 
      Console.WriteLine("Opção Inválida");
      break;
  }
}

void ExibirMensagemPrincipal() {
  Console.WriteLine("Digite o codigo de acordo com o que você quer");
  Console.WriteLine("- Cadastro de Pacotes");
  Console.WriteLine("2- Atualizar Pacotes");
  Console.WriteLine("3- Consultar Pacotes");
  Console.WriteLine("0- Sair da Aplicação");
}

void CadastrarPacote() {
  Console.WriteLine("Digite o título.");
  var titulo = Console.ReadLine();

  Console.WriteLine("Digite a descrição.");
  var descricao = Console.ReadLine();

  var pacote = new Pacote(titulo, descricao);

  pacotes.Add(pacote);

  Console.WriteLine($"Pacote com o código {pacote.Codigo} foi cadastrado com sucesso");
}

public class Pacote {
    public Pacote(string titulo, string descricao) 
        {
          Titulo = titulo;
          Descricao = descricao;
          Codigo = GerarCodigo();
          DataPostagem = DateTime.Now;
          Status = "Postado.";
               
        }
  
  private string GerarCodigo() {
    return Guid.NewGuid().ToString();
  }

  public void AtualizarStatus(string status) {
    Status = status;
  }
  
  public string Titulo { get; set; }

  public string Descricao { get; set; }

  public string Codigo { get; set; }

  public DateTime DataPostagem { get; set; }

  public string Status { get; set; }

}

  