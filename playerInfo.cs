using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class playerInfo : MonoBehaviour
{
 
//stamina setup
public Slider staminaSlider;
public int maxStamina = 100;
private int staminaFallrate;
public int staminaFallMult=10;
private int staminaRegainRate;
public int staminaRegainMult = 10;
private CharacterController charController;
private FirstPersonController playerController;

//Health Setup
public Slider healthBar;
public int maxHealth= 100;
public int currenthealth ;
public static int damagegetting;
public int damage =10;

public static int totalGold = 0;

    public bool InDamageArea;
    public bool stopDealDamage; 
void Start(){
 
//health
currenthealth =maxHealth;
healthBar.value =currenthealth;



    //stamina
staminaSlider.maxValue = maxStamina;
staminaSlider.value = maxStamina;
staminaFallrate=1;
staminaRegainRate=1;


charController = GetComponent<CharacterController>();
playerController = GetComponent<FirstPersonController>();

}
void Update(){
stam();
 if(InDamageArea == true){

        if(stopDealDamage == false){
            stopDealDamage =true;
            StartCoroutine (damagezone());

            currenthealth-=damage;
            healthBar.value =currenthealth;
            if (currenthealth <= 0)
            {
              FindObjectOfType<gameManager>().EndGame();
            currenthealth = 100;
            }
        }



}
   void setHealth(int heal){
    currenthealth = currenthealth + heal;
}


    IEnumerator damagezone(){
        yield return new WaitForSeconds(3);
 setHealth(-10);
        stopDealDamage = false;
    }
}

public void areain(){
       InDamageArea  = true;
}
public void areaout(){
       InDamageArea  = false;
}
public void deatharea(){
    currenthealth = currenthealth -100;
     FindObjectOfType<gameManager>().EndGame();
}



public void stam(){
    
if(Input.GetKey(KeyCode.LeftShift))
{

    staminaSlider.value-= Time.deltaTime / staminaFallrate * staminaFallMult;

}else{
    staminaSlider.value+=Time.deltaTime  / staminaRegainRate*staminaRegainMult;

}if (staminaSlider.value>= maxStamina)
{
    staminaSlider.value=maxStamina;
}else if (staminaSlider.value <= 0)
{
    staminaSlider.value = 0;
    playerController.m_RunSpeed = playerController.m_WalkSpeed;

}else if(staminaSlider.value >= 0){

playerController.m_RunSpeed = playerController.m_RunSpeedNorm;
}
}

}