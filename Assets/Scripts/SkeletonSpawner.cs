using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject skeleton;
    private Vector3 spawnPos = new Vector3(1, 0, -9);
    public ParticleSystem dirtParticles;
    public ParticleSystem newDirt;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Instantiate(skeleton, transform.position, skeleton.transform.rotation);
            newDirt = Instantiate(dirtParticles, transform.position, skeleton.transform.rotation);
            newDirt.Play();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        newDirt.Stop();
    }
}
