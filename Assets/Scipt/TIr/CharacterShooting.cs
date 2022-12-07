using UnityEngine;

public class CharacterShooting : MonoBehaviour
{
    public Gun gun;
    public Animator animator; 
    public int shootButton;
    public KeyCode reloadKey;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButton(shootButton))
        {
            gun.Shoot();
            animator.SetBool("Shooting", true);
        }
        else animator.SetBool("Shooting", false);



        if (Input.GetKeyDown(reloadKey))
        {
            gun.Reload();
        }
    }
}