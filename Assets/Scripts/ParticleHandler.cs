using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHandler : MonoBehaviour
{

    public ParticleSystem muzzle, beam, particles;

    void GunParticlesEvent()
    {
        muzzle.Play();
        beam.Play();
        particles.Play();
    }
}
