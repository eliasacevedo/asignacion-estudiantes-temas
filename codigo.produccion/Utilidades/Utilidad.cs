using System.Collections.Generic;
using System;

namespace codigo.produccion.Utilidades
{
    public interface IUtilidad{
        List<int> AsignarAleatoriamente<A,B>(List<A> listaA, List<B> listaB);
    }

    public class Utilidad : IUtilidad
    {
        public List<int> AsignarAleatoriamente<A, B>(List<A> listaA, List<B> listaB)
        {
            if (listaA.Count < listaB.Count) {
                throw new System.Exception("La lista A no puede ser menor que la B");
            }
            var random = new Random();
            var listaIndicesA = new List<int>();

            var indicesListaB = generarIndicesDisponibles(listaB.Count);
            listaA.ForEach((elemento) => {
                if (indicesListaB.Count == 0) {
                    indicesListaB = generarIndicesDisponibles(listaB.Count);
                }

                var vr = random.Next(0, indicesListaB.Count);
                listaIndicesA.Add(indicesListaB[vr]);
                indicesListaB.RemoveAt(vr);
            });

            return listaIndicesA;
        }

        private List<int> generarIndicesDisponibles(int cantidad) {
            var indices = new List<int>();
            for (int indice = 0; indice < cantidad; indice++)
            {
                indices.Add(indice);
            }

            return indices;
        }
    }
}