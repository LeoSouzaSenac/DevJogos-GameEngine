using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int health; //A vida do inimigo
    public ParticleSystem explosao; // referência à partícula original
    private ParticleSystem copia; // Cópia da partícula
    
    
    
    // Start is called before the first frame update

    void Start()
    {
        
        health = 100;
    }

    public void TakeDamage(int damage) {
        health -= damage;

    }
    private void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Projetil")) {
            TakeDamage(50);
            Destroy(other.gameObject);

            if (health <= 0) {
                
                Destroy(this.gameObject);
                
                copia = Instantiate(explosao, this.transform.position, Quaternion.identity);
            }
        }
    }

   
}





//Criar um script para o objeto/inimigo (eu chamei de EnemyStats)

/*
    dê uma tag para o prefab projetil;
    crie uma particula para rodar quando o obstaculo/inimigo 'morre';
    no script do obstaculo/inimigo, crie um método chamado TakeDamage, parecido com o que o PlayerStats tem;
    crie um método (private void OnCollisionEnter(Collision other)) e, dentro dele, SE o objeto que colidir tiver a tag "Projetil", tira vida, e quando a vida for 0 ou menor, destrói o inimigo e faz aparecer a explosão.

*/