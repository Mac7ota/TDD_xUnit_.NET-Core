using Domain.Entitys;

namespace SistemaTarefasInteligentes.Test
{
    public class TarefasTests
    {
        [Fact]
        public void CriarTarefasComSucesso()
        {
            //Arrange
            var titulo = "Tarefa 1";
            var descricao = "Descrição da tarefa 1";
            var dataVencimento = DateTime.Now;
            var prioridade = 1;
            var etiquetas = new List<string> { "etiqueta1", "etiqueta2" };

            //Act
            var tarefa = new Tarefa(titulo,descricao,dataVencimento,prioridade,etiquetas);

            //Assert
            Assert.Equal(titulo, tarefa.Titulo);
            Assert.Equal(descricao, tarefa.Descricao);
            Assert.Equal(dataVencimento, tarefa.DataVencimento);
            


        }
    }
}