using UnityEngine;
using System.Collections;
using System;

public static class SaveAndLoad
{
    public static void Initialize()
    {
        SavePosition = true;

        ResetAngularVelocity = true;
        ResetRotation = true;
        ResetVelocity = true;
    }

    public static void SetInitialState(PlayerMoveSphere player)
    {
        Rigidbody state = player.GetComponent<Rigidbody>();
        int id = player.playerNumber;

        if (SaveAngularDrag)
            PlayerPrefs.SetFloat("_AngularDrag" + id.ToString(), state.angularDrag);
        if (SaveAngularVelocity)
        {
            PlayerPrefs.SetFloat("_AngularVelocityX" + id.ToString(), state.angularVelocity.x);
            PlayerPrefs.SetFloat("_AngularVelocityY" + id.ToString(), state.angularVelocity.y);
            PlayerPrefs.SetFloat("_AngularVelocityZ" + id.ToString(), state.angularVelocity.z);
        }
        if (SaveCenterOfMass)
        {
            PlayerPrefs.SetFloat("_CenterOfMassX" + id.ToString(), state.centerOfMass.x);
            PlayerPrefs.SetFloat("_CenterOfMassY" + id.ToString(), state.centerOfMass.y);
            PlayerPrefs.SetFloat("_CenterOfMassZ" + id.ToString(), state.centerOfMass.z);
        }
        if (SaveCollisionDetectionMode)
            PlayerPrefs.SetInt("_CollisionDetectionMode" + id.ToString(), (int)state.collisionDetectionMode);
        if (SaveConstraints)
            PlayerPrefs.SetInt("_Constraints" + id.ToString(), (int)state.constraints);
        if (SaveDetectCollisions)
            PlayerPrefs.SetInt("_DetectCollisions" + id.ToString(), Convert.ToInt32(state.detectCollisions));
        if (SaveDrag)
            PlayerPrefs.SetFloat("_Drag" + id.ToString(), state.drag);
        if (SaveFreezeRotations)
            PlayerPrefs.SetInt("_FreezeRotation" + id.ToString(), Convert.ToInt32(state.freezeRotation));
        if (SaveHideFlags)
            PlayerPrefs.SetInt("_HideFlags" + id.ToString(), (int)state.hideFlags);
        if (SaveInertiaTensor)
        {
            PlayerPrefs.SetFloat("_InertiaTensorX" + id.ToString(), state.inertiaTensor.x);
            PlayerPrefs.SetFloat("_InertiaTensorY" + id.ToString(), state.inertiaTensor.y);
            PlayerPrefs.SetFloat("_InertiaTensorZ" + id.ToString(), state.inertiaTensor.z);
        }
        if (SaveInertiaTensorRotation)
        {
            PlayerPrefs.SetFloat("_InertiaTensorRotationW" + id.ToString(), state.inertiaTensorRotation.w);
            PlayerPrefs.SetFloat("_InertiaTensorRotationX" + id.ToString(), state.inertiaTensorRotation.x);
            PlayerPrefs.SetFloat("_InertiaTensorRotationY" + id.ToString(), state.inertiaTensorRotation.y);
            PlayerPrefs.SetFloat("_InertiaTensorRotationZ" + id.ToString(), state.inertiaTensorRotation.z);
        }
        if (SaveInterpolation)
            PlayerPrefs.SetInt("_Interpolation" + id.ToString(), (int)state.interpolation);
        if (SaveIsKinematic)
            PlayerPrefs.SetInt("_IsKinematic" + id.ToString(), Convert.ToInt32(state.isKinematic));
        if (SaveMass)
            PlayerPrefs.SetFloat("_Mass" + id.ToString(), state.mass);
        if (SaveMaxAngularVelocity)
            PlayerPrefs.SetFloat("_MaxAngularVelocity" + id.ToString(), state.maxAngularVelocity);
        if (SaveMaxDepenetrationVelocity)
            PlayerPrefs.SetFloat("_MaxDepenetrationVelocity" + id.ToString(), state.maxDepenetrationVelocity);
        if (SaveName)
            PlayerPrefs.SetString("_Name" + id.ToString(), state.name);
        if (SavePosition)
        {
            PlayerPrefs.SetFloat("_PositionX" + id.ToString(), state.position.x);
            PlayerPrefs.SetFloat("_PositionY" + id.ToString(), state.position.y);
            PlayerPrefs.SetFloat("_PositionZ" + id.ToString(), state.position.z);
        }
        if (SaveRotation)
        {
            PlayerPrefs.SetFloat("_RotationW" + id.ToString(), state.rotation.w);
            PlayerPrefs.SetFloat("_RotationX" + id.ToString(), state.rotation.x);
            PlayerPrefs.SetFloat("_RotationY" + id.ToString(), state.rotation.y);
            PlayerPrefs.SetFloat("_RotationZ" + id.ToString(), state.rotation.z);
        }
        if (SaveSleepThreshold)
            PlayerPrefs.SetFloat("_SleepThreshold" + id.ToString(), state.sleepThreshold);
        if (SaveSolverIterations)
            PlayerPrefs.SetInt("_SolverIterations" + id.ToString(), state.solverIterations);
        if (SaveSolverVelocityIterations)
            PlayerPrefs.SetInt("_SolverVelocityIterations" + id.ToString(), state.solverVelocityIterations);
        if (SaveTag)
            PlayerPrefs.SetString("_Tag" + id.ToString(), state.tag);
        if (SaveUseConeFriction)
            PlayerPrefs.SetInt("_UseConeFriction" + id.ToString(), Convert.ToInt32(state.useConeFriction));
        if (SaveUseGravity)
            PlayerPrefs.SetInt("_UseGravity" + id.ToString(), Convert.ToInt32(state.useGravity));
        if (SaveVelocity)
        {
            PlayerPrefs.SetFloat("_VelocityX" + id.ToString(), state.velocity.x);
            PlayerPrefs.SetFloat("_VelocityY" + id.ToString(), state.velocity.y);
            PlayerPrefs.SetFloat("_VelocityZ" + id.ToString(), state.velocity.z);
        }
    }

    public static void SaveState(PlayerMoveSphere player)
    {
        Rigidbody state = player.GetComponent<Rigidbody>();
        int id = player.playerNumber;

        if (SaveAngularDrag)
            PlayerPrefs.SetFloat("AngularDrag" + id.ToString(), state.angularDrag);
        if (SaveAngularVelocity)
        {
            PlayerPrefs.SetFloat("AngularVelocityX" + id.ToString(), state.angularVelocity.x);
            PlayerPrefs.SetFloat("AngularVelocityY" + id.ToString(), state.angularVelocity.y);
            PlayerPrefs.SetFloat("AngularVelocityZ" + id.ToString(), state.angularVelocity.z);
        }
        if (SaveCenterOfMass)
        {
            PlayerPrefs.SetFloat("CenterOfMassX" + id.ToString(), state.centerOfMass.x);
            PlayerPrefs.SetFloat("CenterOfMassY" + id.ToString(), state.centerOfMass.y);
            PlayerPrefs.SetFloat("CenterOfMassZ" + id.ToString(), state.centerOfMass.z);
        }
        if (SaveCollisionDetectionMode)
            PlayerPrefs.SetInt("CollisionDetectionMode" + id.ToString(), (int)state.collisionDetectionMode);
        if (SaveConstraints)
            PlayerPrefs.SetInt("Constraints" + id.ToString(), (int)state.constraints);
        if (SaveDetectCollisions)
            PlayerPrefs.SetInt("DetectCollisions" + id.ToString(), Convert.ToInt32(state.detectCollisions));
        if (SaveDrag)
            PlayerPrefs.SetFloat("Drag" + id.ToString(), state.drag);
        if (SaveFreezeRotations)
            PlayerPrefs.SetInt("FreezeRotation" + id.ToString(), Convert.ToInt32(state.freezeRotation));
        if (SaveHideFlags)
            PlayerPrefs.SetInt("HideFlags" + id.ToString(), (int)state.hideFlags);
        if (SaveInertiaTensor)
        {
            PlayerPrefs.SetFloat("InertiaTensorX" + id.ToString(), state.inertiaTensor.x);
            PlayerPrefs.SetFloat("InertiaTensorY" + id.ToString(), state.inertiaTensor.y);
            PlayerPrefs.SetFloat("InertiaTensorZ" + id.ToString(), state.inertiaTensor.z);
        }
        if (SaveInertiaTensorRotation)
        {
            PlayerPrefs.SetFloat("InertiaTensorRotationW" + id.ToString(), state.inertiaTensorRotation.w);
            PlayerPrefs.SetFloat("InertiaTensorRotationX" + id.ToString(), state.inertiaTensorRotation.x);
            PlayerPrefs.SetFloat("InertiaTensorRotationY" + id.ToString(), state.inertiaTensorRotation.y);
            PlayerPrefs.SetFloat("InertiaTensorRotationZ" + id.ToString(), state.inertiaTensorRotation.z);
        }
        if (SaveInterpolation)
            PlayerPrefs.SetInt("Interpolation" + id.ToString(), (int)state.interpolation);
        if (SaveIsKinematic)
            PlayerPrefs.SetInt("IsKinematic" + id.ToString(), Convert.ToInt32(state.isKinematic));
        if (SaveMass)
            PlayerPrefs.SetFloat("Mass" + id.ToString(), state.mass);
        if (SaveMaxAngularVelocity)
            PlayerPrefs.SetFloat("MaxAngularVelocity" + id.ToString(), state.maxAngularVelocity);
        if (SaveMaxDepenetrationVelocity)
            PlayerPrefs.SetFloat("MaxDepenetrationVelocity" + id.ToString(), state.maxDepenetrationVelocity);
        if (SaveName)
            PlayerPrefs.SetString("Name" + id.ToString(), state.name);
        if (SavePosition)
        {
            PlayerPrefs.SetFloat("PositionX" + id.ToString(), state.position.x);
            PlayerPrefs.SetFloat("PositionY" + id.ToString(), state.position.y);
            PlayerPrefs.SetFloat("PositionZ" + id.ToString(), state.position.z);
        }
        if (SaveRotation)
        {
            PlayerPrefs.SetFloat("RotationW" + id.ToString(), state.rotation.w);
            PlayerPrefs.SetFloat("RotationX" + id.ToString(), state.rotation.x);
            PlayerPrefs.SetFloat("RotationY" + id.ToString(), state.rotation.y);
            PlayerPrefs.SetFloat("RotationZ" + id.ToString(), state.rotation.z);
        }
        if (SaveSleepThreshold)
            PlayerPrefs.SetFloat("SleepThreshold" + id.ToString(), state.sleepThreshold);
        if (SaveSolverIterations)
            PlayerPrefs.SetInt("SolverIterations" + id.ToString(), state.solverIterations);
        if (SaveSolverVelocityIterations)
            PlayerPrefs.SetInt("SolverVelocityIterations" + id.ToString(), state.solverVelocityIterations);
        if (SaveTag)
            PlayerPrefs.SetString("Tag" + id.ToString(), state.tag);
        if (SaveUseConeFriction)
            PlayerPrefs.SetInt("UseConeFriction" + id.ToString(), Convert.ToInt32(state.useConeFriction));
        if (SaveUseGravity)
            PlayerPrefs.SetInt("UseGravity" + id.ToString(), Convert.ToInt32(state.useGravity));
        if (SaveVelocity)
        {
            PlayerPrefs.SetFloat("VelocityX" + id.ToString(), state.velocity.x);
            PlayerPrefs.SetFloat("VelocityY" + id.ToString(), state.velocity.y);
            PlayerPrefs.SetFloat("VelocityZ" + id.ToString(), state.velocity.z);
        }
    }

    public static void LoadState(PlayerMoveSphere player)
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();
        int id = player.playerNumber;

        float x, y, z, w;

        if (SaveAngularDrag)
            rb.angularDrag = PlayerPrefs.GetFloat("AngularDrag" + id.ToString());
        else if (ResetAngularDrag)
            rb.angularDrag = PlayerPrefs.GetFloat("_AngularDrag" + id.ToString());

        if (SaveAngularVelocity)
        {
            x = PlayerPrefs.GetFloat("AngularVelocityX" + id.ToString());
            y = PlayerPrefs.GetFloat("AngularVelocityY" + id.ToString());
            z = PlayerPrefs.GetFloat("AngularVelocityZ" + id.ToString());
            rb.angularVelocity = new Vector3(x, y, z);
        }
        else if (ResetAngularVelocity)
        {
            x = PlayerPrefs.GetFloat("_AngularVelocityX" + id.ToString());
            y = PlayerPrefs.GetFloat("_AngularVelocityY" + id.ToString());
            z = PlayerPrefs.GetFloat("_AngularVelocityZ" + id.ToString());
            rb.angularVelocity = new Vector3(x, y, z);
        }

        if (SaveCenterOfMass)
        {
            x = PlayerPrefs.GetFloat("CenterOfMassX" + id.ToString());
            y = PlayerPrefs.GetFloat("CenterOfMassY" + id.ToString());
            z = PlayerPrefs.GetFloat("CenterOfMassZ" + id.ToString());
            rb.centerOfMass = new Vector3(x, y, z);
        }
        else if (ResetCenterOfMass)
        {
            x = PlayerPrefs.GetFloat("_CenterOfMassX" + id.ToString());
            y = PlayerPrefs.GetFloat("_CenterOfMassY" + id.ToString());
            z = PlayerPrefs.GetFloat("_CenterOfMassZ" + id.ToString());
            rb.centerOfMass = new Vector3(x, y, z);
        }

        if (SaveCollisionDetectionMode)
            rb.collisionDetectionMode = (CollisionDetectionMode)PlayerPrefs.GetInt("CollisionDetectionMode" + id.ToString());
        else if (ResetCollisionDetectionMode)
            rb.collisionDetectionMode = (CollisionDetectionMode)PlayerPrefs.GetInt("_CollisionDetectionMode" + id.ToString());

        if (SaveConstraints)
            rb.constraints = (RigidbodyConstraints)PlayerPrefs.GetInt("Constraints" + id.ToString());
        else if (ResetConstraints)
            rb.constraints = (RigidbodyConstraints)PlayerPrefs.GetInt("_Constraints" + id.ToString());

        if (SaveDetectCollisions)
            rb.detectCollisions = Convert.ToBoolean(PlayerPrefs.GetInt("DetectCollisions" + id.ToString()));
        else if (ResetDetectCollisions)
            rb.detectCollisions = Convert.ToBoolean(PlayerPrefs.GetInt("_DetectCollisions" + id.ToString()));

        if (SaveDrag)
            rb.drag = PlayerPrefs.GetFloat("Drag" + id.ToString());
        else if (ResetDrag)
            rb.drag = PlayerPrefs.GetFloat("_Drag" + id.ToString());

        if (SaveFreezeRotations)
            rb.freezeRotation = Convert.ToBoolean(PlayerPrefs.GetInt("FreezeRotation" + id.ToString()));
        else if (ResetFreezeRotations)
            rb.freezeRotation = Convert.ToBoolean(PlayerPrefs.GetInt("_FreezeRotation" + id.ToString()));

        if (SaveHideFlags)
            rb.hideFlags = (HideFlags)PlayerPrefs.GetInt("HideFlags" + id.ToString());
        else if (ResetHideFlags)
            rb.hideFlags = (HideFlags)PlayerPrefs.GetInt("_HideFlags" + id.ToString());

        if (SaveInertiaTensor)
        {
            x = PlayerPrefs.GetFloat("InertiaTensorX" + id.ToString());
            y = PlayerPrefs.GetFloat("InertiaTensorY" + id.ToString());
            z = PlayerPrefs.GetFloat("InertiaTensorZ" + id.ToString());
            rb.inertiaTensor = new Vector3(x, y, z);
        }
        else if (ResetInertiaTensor)
        {
            x = PlayerPrefs.GetFloat("_InertiaTensorX" + id.ToString());
            y = PlayerPrefs.GetFloat("_InertiaTensorY" + id.ToString());
            z = PlayerPrefs.GetFloat("_InertiaTensorZ" + id.ToString());
            rb.inertiaTensor = new Vector3(x, y, z);
        }

        if (SaveInertiaTensorRotation)
        {
            w = PlayerPrefs.GetFloat("InertiaTensorRotationW" + id.ToString());
            x = PlayerPrefs.GetFloat("InertiaTensorRotationX" + id.ToString());
            y = PlayerPrefs.GetFloat("InertiaTensorRotationY" + id.ToString());
            z = PlayerPrefs.GetFloat("InertiaTensorRotationZ" + id.ToString());
            rb.inertiaTensorRotation = new Quaternion(x, y, z, w);
        }
        else if (ResetInertiaTensorRotation)
        {
            w = PlayerPrefs.GetFloat("_InertiaTensorRotationW" + id.ToString());
            x = PlayerPrefs.GetFloat("_InertiaTensorRotationX" + id.ToString());
            y = PlayerPrefs.GetFloat("_InertiaTensorRotationY" + id.ToString());
            z = PlayerPrefs.GetFloat("_InertiaTensorRotationZ" + id.ToString());
            rb.inertiaTensorRotation = new Quaternion(x, y, z, w);
        }

        if (SaveInterpolation)
            rb.interpolation = (RigidbodyInterpolation)PlayerPrefs.GetInt("Interpolation" + id.ToString());
        else if (ResetInterpolation)
            rb.interpolation = (RigidbodyInterpolation)PlayerPrefs.GetInt("_Interpolation" + id.ToString());

        if (SaveIsKinematic)
            rb.isKinematic = Convert.ToBoolean(PlayerPrefs.GetInt("IsKinematic" + id.ToString()));
        else if (ResetIsKinematic)
            rb.isKinematic = Convert.ToBoolean(PlayerPrefs.GetInt("_IsKinematic" + id.ToString()));

        if (SaveMass)
            rb.mass = PlayerPrefs.GetFloat("Mass" + id.ToString());
        else if (ResetMass)
            rb.mass = PlayerPrefs.GetFloat("_Mass" + id.ToString());

        if (SaveMaxAngularVelocity)
            rb.maxAngularVelocity = PlayerPrefs.GetFloat("MaxAngularVelocity" + id.ToString());
        else if (ResetMaxAngularVelocity)
            rb.maxAngularVelocity = PlayerPrefs.GetFloat("_MaxAngularVelocity" + id.ToString());

        if (SaveMaxDepenetrationVelocity)
            rb.maxDepenetrationVelocity = PlayerPrefs.GetFloat("MaxDepenetrationVelocity" + id.ToString());
        else if (ResetMaxDepenetrationVelocity)
            rb.maxDepenetrationVelocity = PlayerPrefs.GetFloat("_MaxDepenetrationVelocity" + id.ToString());

        if (SaveName)
            rb.name = PlayerPrefs.GetString("Name" + id.ToString());
        else if (ResetName)
            rb.name = PlayerPrefs.GetString("_Name" + id.ToString());

        if (SavePosition)
        {
            x = PlayerPrefs.GetFloat("PositionX" + id.ToString());
            y = PlayerPrefs.GetFloat("PositionY" + id.ToString());
            z = PlayerPrefs.GetFloat("PositionZ" + id.ToString());
            rb.position = new Vector3(x, y, z);
        }
        else if (ResetPosition)
        {
            x = PlayerPrefs.GetFloat("_PositionX" + id.ToString());
            y = PlayerPrefs.GetFloat("_PositionY" + id.ToString());
            z = PlayerPrefs.GetFloat("_PositionZ" + id.ToString());
            rb.position = new Vector3(x, y, z);
        }

        if (SaveRotation)
        {
            w = PlayerPrefs.GetFloat("RotationW" + id.ToString());
            x = PlayerPrefs.GetFloat("RotationX" + id.ToString());
            y = PlayerPrefs.GetFloat("RotationY" + id.ToString());
            z = PlayerPrefs.GetFloat("RotationZ" + id.ToString());
            rb.rotation = new Quaternion(x, y, z, w);
        }
        else if (ResetRotation)
        {
            w = PlayerPrefs.GetFloat("_RotationW" + id.ToString());
            x = PlayerPrefs.GetFloat("_RotationX" + id.ToString());
            y = PlayerPrefs.GetFloat("_RotationY" + id.ToString());
            z = PlayerPrefs.GetFloat("_RotationZ" + id.ToString());
            rb.rotation = new Quaternion(x, y, z, w);
        }

        if (SaveSleepThreshold)
            rb.sleepThreshold = PlayerPrefs.GetFloat("SleepThreshold" + id.ToString());
        else if (ResetSleepThreshold)
            rb.sleepThreshold = PlayerPrefs.GetFloat("_SleepThreshold" + id.ToString());

        if (SaveSolverIterations)
            rb.solverIterations = PlayerPrefs.GetInt("SolverIterations" + id.ToString());
        else if (ResetSolverIterations)
            rb.solverIterations = PlayerPrefs.GetInt("_SolverIterations" + id.ToString());

        if (SaveSolverVelocityIterations)
            rb.solverVelocityIterations = PlayerPrefs.GetInt("SolverVelocityIterations" + id.ToString());
        else if (ResetSolverVelocityIterations)
            rb.solverVelocityIterations = PlayerPrefs.GetInt("_SolverVelocityIterations" + id.ToString());

        if (SaveTag)
            rb.tag = PlayerPrefs.GetString("Tag" + id.ToString());
        else if (ResetTag)
            rb.tag = PlayerPrefs.GetString("_Tag" + id.ToString());

        if (SaveUseConeFriction)
            rb.useConeFriction = Convert.ToBoolean(PlayerPrefs.GetInt("UseConeFriction" + id.ToString()));
        else if (ResetUseConeFriction)
            rb.useConeFriction = Convert.ToBoolean(PlayerPrefs.GetInt("_UseConeFriction" + id.ToString()));

        if (SaveUseGravity)
            rb.useGravity = Convert.ToBoolean(PlayerPrefs.GetInt("UseGravity" + id.ToString()));
        else if (ResetUseGravity)
            rb.useGravity = Convert.ToBoolean(PlayerPrefs.GetInt("_UseGravity" + id.ToString()));

        if (SaveVelocity)
        {
            x = PlayerPrefs.GetFloat("VelocityX" + id.ToString());
            y = PlayerPrefs.GetFloat("VelocityY" + id.ToString());
            z = PlayerPrefs.GetFloat("VelocityZ" + id.ToString());
            rb.velocity = new Vector3(x, y, z);
        }
        else if (ResetVelocity)
        {
            x = PlayerPrefs.GetFloat("_VelocityX" + id.ToString());
            y = PlayerPrefs.GetFloat("_VelocityY" + id.ToString());
            z = PlayerPrefs.GetFloat("_VelocityZ" + id.ToString());
            rb.velocity = new Vector3(x, y, z);
        }

    }

    public static bool SaveAngularDrag { get; set; }
    public static bool SaveAngularVelocity { get; set; }
    public static bool SaveCenterOfMass { get; set; }
    public static bool SaveCollisionDetectionMode { get; set; }
    public static bool SaveConstraints { get; set; }
    public static bool SaveDetectCollisions { get; set; }
    public static bool SaveDrag { get; set; }
    public static bool SaveFreezeRotations { get; set; }
    public static bool SaveHideFlags { get; set; }
    public static bool SaveInertiaTensor { get; set; }
    public static bool SaveInertiaTensorRotation { get; set; }
    public static bool SaveInterpolation { get; set; }
    public static bool SaveIsKinematic { get; set; }
    public static bool SaveMass { get; set; }
    public static bool SaveMaxAngularVelocity { get; set; }
    public static bool SaveMaxDepenetrationVelocity { get; set; }
    public static bool SaveName { get; set; }
    public static bool SavePosition { get; set; }
    public static bool SaveRotation { get; set; }
    public static bool SaveSleepThreshold { get; set; }
    public static bool SaveSolverIterations { get; set; }
    public static bool SaveSolverVelocityIterations { get; set; }
    public static bool SaveTag { get; set; }
    public static bool SaveUseConeFriction { get; set; }
    public static bool SaveUseGravity { get; set; }
    public static bool SaveVelocity { get; set; }

    public static bool ResetAngularDrag { get; set; }
    public static bool ResetAngularVelocity { get; set; }
    public static bool ResetCenterOfMass { get; set; }
    public static bool ResetCollisionDetectionMode { get; set; }
    public static bool ResetConstraints { get; set; }
    public static bool ResetDetectCollisions { get; set; }
    public static bool ResetDrag { get; set; }
    public static bool ResetFreezeRotations { get; set; }
    public static bool ResetHideFlags { get; set; }
    public static bool ResetInertiaTensor { get; set; }
    public static bool ResetInertiaTensorRotation { get; set; }
    public static bool ResetInterpolation { get; set; }
    public static bool ResetIsKinematic { get; set; }
    public static bool ResetMass { get; set; }
    public static bool ResetMaxAngularVelocity { get; set; }
    public static bool ResetMaxDepenetrationVelocity { get; set; }
    public static bool ResetName { get; set; }
    public static bool ResetPosition { get; set; }
    public static bool ResetRotation { get; set; }
    public static bool ResetSleepThreshold { get; set; }
    public static bool ResetSolverIterations { get; set; }
    public static bool ResetSolverVelocityIterations { get; set; }
    public static bool ResetTag { get; set; }
    public static bool ResetUseConeFriction { get; set; }
    public static bool ResetUseGravity { get; set; }
    public static bool ResetVelocity { get; set; }
}
