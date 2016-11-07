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

    public static void SetInitialState(Rigidbody state)
    {
        if (SaveAngularDrag)
            PlayerPrefs.SetFloat("_AngularDrag", state.angularDrag);
        if (SaveAngularVelocity)
        {
            PlayerPrefs.SetFloat("_AngularVelocityX", state.angularVelocity.x);
            PlayerPrefs.SetFloat("_AngularVelocityY", state.angularVelocity.y);
            PlayerPrefs.SetFloat("_AngularVelocityZ", state.angularVelocity.z);
        }
        if (SaveCenterOfMass)
        {
            PlayerPrefs.SetFloat("_CenterOfMassX", state.centerOfMass.x);
            PlayerPrefs.SetFloat("_CenterOfMassY", state.centerOfMass.y);
            PlayerPrefs.SetFloat("_CenterOfMassZ", state.centerOfMass.z);
        }
        if (SaveCollisionDetectionMode)
            PlayerPrefs.SetInt("_CollisionDetectionMode", (int)state.collisionDetectionMode);
        if (SaveConstraints)
            PlayerPrefs.SetInt("_Constraints", (int)state.constraints);
        if (SaveDetectCollisions)
            PlayerPrefs.SetInt("_DetectCollisions", Convert.ToInt32(state.detectCollisions));
        if (SaveDrag)
            PlayerPrefs.SetFloat("_Drag", state.drag);
        if (SaveFreezeRotations)
            PlayerPrefs.SetInt("_FreezeRotation", Convert.ToInt32(state.freezeRotation));
        if (SaveHideFlags)
            PlayerPrefs.SetInt("_HideFlags", (int)state.hideFlags);
        if (SaveInertiaTensor)
        {
            PlayerPrefs.SetFloat("_InertiaTensorX", state.inertiaTensor.x);
            PlayerPrefs.SetFloat("_InertiaTensorY", state.inertiaTensor.y);
            PlayerPrefs.SetFloat("_InertiaTensorZ", state.inertiaTensor.z);
        }
        if (SaveInertiaTensorRotation)
        {
            PlayerPrefs.SetFloat("_InertiaTensorRotationW", state.inertiaTensorRotation.w);
            PlayerPrefs.SetFloat("_InertiaTensorRotationX", state.inertiaTensorRotation.x);
            PlayerPrefs.SetFloat("_InertiaTensorRotationY", state.inertiaTensorRotation.y);
            PlayerPrefs.SetFloat("_InertiaTensorRotationZ", state.inertiaTensorRotation.z);
        }
        if (SaveInterpolation)
            PlayerPrefs.SetInt("_Interpolation", (int)state.interpolation);
        if (SaveIsKinematic)
            PlayerPrefs.SetInt("_IsKinematic", Convert.ToInt32(state.isKinematic));
        if (SaveMass)
            PlayerPrefs.SetFloat("_Mass", state.mass);
        if (SaveMaxAngularVelocity)
            PlayerPrefs.SetFloat("_MaxAngularVelocity", state.maxAngularVelocity);
        if (SaveMaxDepenetrationVelocity)
            PlayerPrefs.SetFloat("_MaxDepenetrationVelocity", state.maxDepenetrationVelocity);
        if (SaveName)
            PlayerPrefs.SetString("_Name", state.name);
        if (SavePosition)
        {
            PlayerPrefs.SetFloat("_PositionX", state.position.x);
            PlayerPrefs.SetFloat("_PositionY", state.position.y);
            PlayerPrefs.SetFloat("_PositionZ", state.position.z);
        }
        if (SaveRotation)
        {
            PlayerPrefs.SetFloat("_RotationW", state.rotation.w);
            PlayerPrefs.SetFloat("_RotationX", state.rotation.x);
            PlayerPrefs.SetFloat("_RotationY", state.rotation.y);
            PlayerPrefs.SetFloat("_RotationZ", state.rotation.z);
        }
        if (SaveSleepThreshold)
            PlayerPrefs.SetFloat("_SleepThreshold", state.sleepThreshold);
        if (SaveSolverIterations)
            PlayerPrefs.SetInt("_SolverIterations", state.solverIterations);
        if (SaveSolverVelocityIterations)
            PlayerPrefs.SetInt("_SolverVelocityIterations", state.solverVelocityIterations);
        if (SaveTag)
            PlayerPrefs.SetString("_Tag", state.tag);
        if (SaveUseConeFriction)
            PlayerPrefs.SetInt("_UseConeFriction", Convert.ToInt32(state.useConeFriction));
        if (SaveUseGravity)
            PlayerPrefs.SetInt("_UseGravity", Convert.ToInt32(state.useGravity));
        if (SaveVelocity)
        {
            PlayerPrefs.SetFloat("_VelocityX", state.velocity.x);
            PlayerPrefs.SetFloat("_VelocityY", state.velocity.y);
            PlayerPrefs.SetFloat("_VelocityZ", state.velocity.z);
        }
    }

    public static void SaveState(Rigidbody state)
    {
        if (SaveAngularDrag)
            PlayerPrefs.SetFloat("AngularDrag", state.angularDrag);
        if (SaveAngularVelocity)
        {
            PlayerPrefs.SetFloat("AngularVelocityX", state.angularVelocity.x);
            PlayerPrefs.SetFloat("AngularVelocityY", state.angularVelocity.y);
            PlayerPrefs.SetFloat("AngularVelocityZ", state.angularVelocity.z);
        }
        if (SaveCenterOfMass)
        {
            PlayerPrefs.SetFloat("CenterOfMassX", state.centerOfMass.x);
            PlayerPrefs.SetFloat("CenterOfMassY", state.centerOfMass.y);
            PlayerPrefs.SetFloat("CenterOfMassZ", state.centerOfMass.z);
        }
        if (SaveCollisionDetectionMode)
            PlayerPrefs.SetInt("CollisionDetectionMode", (int)state.collisionDetectionMode);
        if (SaveConstraints)
            PlayerPrefs.SetInt("Constraints", (int)state.constraints);
        if (SaveDetectCollisions)
            PlayerPrefs.SetInt("DetectCollisions", Convert.ToInt32(state.detectCollisions));
        if (SaveDrag)
            PlayerPrefs.SetFloat("Drag", state.drag);
        if (SaveFreezeRotations)
            PlayerPrefs.SetInt("FreezeRotation", Convert.ToInt32(state.freezeRotation));
        if (SaveHideFlags)
            PlayerPrefs.SetInt("HideFlags", (int)state.hideFlags);
        if (SaveInertiaTensor)
        {
            PlayerPrefs.SetFloat("InertiaTensorX", state.inertiaTensor.x);
            PlayerPrefs.SetFloat("InertiaTensorY", state.inertiaTensor.y);
            PlayerPrefs.SetFloat("InertiaTensorZ", state.inertiaTensor.z);
        }
        if (SaveInertiaTensorRotation)
        {
            PlayerPrefs.SetFloat("InertiaTensorRotationW", state.inertiaTensorRotation.w);
            PlayerPrefs.SetFloat("InertiaTensorRotationX", state.inertiaTensorRotation.x);
            PlayerPrefs.SetFloat("InertiaTensorRotationY", state.inertiaTensorRotation.y);
            PlayerPrefs.SetFloat("InertiaTensorRotationZ", state.inertiaTensorRotation.z);
        }
        if (SaveInterpolation)
            PlayerPrefs.SetInt("Interpolation", (int)state.interpolation);
        if (SaveIsKinematic)
            PlayerPrefs.SetInt("IsKinematic", Convert.ToInt32(state.isKinematic));
        if (SaveMass)
            PlayerPrefs.SetFloat("Mass", state.mass);
        if (SaveMaxAngularVelocity)
            PlayerPrefs.SetFloat("MaxAngularVelocity", state.maxAngularVelocity);
        if (SaveMaxDepenetrationVelocity)
            PlayerPrefs.SetFloat("MaxDepenetrationVelocity", state.maxDepenetrationVelocity);
        if (SaveName)
            PlayerPrefs.SetString("Name", state.name);
        if (SavePosition)
        {
            PlayerPrefs.SetFloat("PositionX", state.position.x);
            PlayerPrefs.SetFloat("PositionY", state.position.y);
            PlayerPrefs.SetFloat("PositionZ", state.position.z);
        }
        if (SaveRotation)
        {
            PlayerPrefs.SetFloat("RotationW", state.rotation.w);
            PlayerPrefs.SetFloat("RotationX", state.rotation.x);
            PlayerPrefs.SetFloat("RotationY", state.rotation.y);
            PlayerPrefs.SetFloat("RotationZ", state.rotation.z);
        }
        if (SaveSleepThreshold)
            PlayerPrefs.SetFloat("SleepThreshold", state.sleepThreshold);
        if (SaveSolverIterations)
            PlayerPrefs.SetInt("SolverIterations", state.solverIterations);
        if (SaveSolverVelocityIterations)
            PlayerPrefs.SetInt("SolverVelocityIterations", state.solverVelocityIterations);
        if (SaveTag)
            PlayerPrefs.SetString("Tag", state.tag);
        if (SaveUseConeFriction)
            PlayerPrefs.SetInt("UseConeFriction", Convert.ToInt32(state.useConeFriction));
        if (SaveUseGravity)
            PlayerPrefs.SetInt("UseGravity", Convert.ToInt32(state.useGravity));
        if (SaveVelocity)
        {
            PlayerPrefs.SetFloat("VelocityX", state.velocity.x);
            PlayerPrefs.SetFloat("VelocityY", state.velocity.y);
            PlayerPrefs.SetFloat("VelocityZ", state.velocity.z);
        }
    }

    public static void LoadState(ref Rigidbody rb)
    {
        float x, y, z, w;

        if (SaveAngularDrag)
            rb.angularDrag = PlayerPrefs.GetFloat("AngularDrag");
        else if (ResetAngularDrag)
            rb.angularDrag = PlayerPrefs.GetFloat("_AngularDrag");

        if (SaveAngularVelocity)
        {
            x = PlayerPrefs.GetFloat("AngularVelocityX");
            y = PlayerPrefs.GetFloat("AngularVelocityY");
            z = PlayerPrefs.GetFloat("AngularVelocityZ");
            rb.angularVelocity = new Vector3(x, y, z);
        }
        else if (ResetAngularVelocity)
        {
            x = PlayerPrefs.GetFloat("_AngularVelocityX");
            y = PlayerPrefs.GetFloat("_AngularVelocityY");
            z = PlayerPrefs.GetFloat("_AngularVelocityZ");
            rb.angularVelocity = new Vector3(x, y, z);
        }

        if (SaveCenterOfMass)
        {
            x = PlayerPrefs.GetFloat("CenterOfMassX");
            y = PlayerPrefs.GetFloat("CenterOfMassY");
            z = PlayerPrefs.GetFloat("CenterOfMassZ");
            rb.centerOfMass = new Vector3(x, y, z);
        }
        else if (ResetCenterOfMass)
        {
            x = PlayerPrefs.GetFloat("_CenterOfMassX");
            y = PlayerPrefs.GetFloat("_CenterOfMassY");
            z = PlayerPrefs.GetFloat("_CenterOfMassZ");
            rb.centerOfMass = new Vector3(x, y, z);
        }

        if (SaveCollisionDetectionMode)
            rb.collisionDetectionMode = (CollisionDetectionMode)PlayerPrefs.GetInt("CollisionDetectionMode");
        else if (ResetCollisionDetectionMode)
            rb.collisionDetectionMode = (CollisionDetectionMode)PlayerPrefs.GetInt("_CollisionDetectionMode");

        if (SaveConstraints)
            rb.constraints = (RigidbodyConstraints)PlayerPrefs.GetInt("Constraints");
        else if (ResetConstraints)
            rb.constraints = (RigidbodyConstraints)PlayerPrefs.GetInt("_Constraints");

        if (SaveDetectCollisions)
            rb.detectCollisions = Convert.ToBoolean(PlayerPrefs.GetInt("DetectCollisions"));
        else if (ResetDetectCollisions)
            rb.detectCollisions = Convert.ToBoolean(PlayerPrefs.GetInt("_DetectCollisions"));

        if (SaveDrag)
            rb.drag = PlayerPrefs.GetFloat("Drag");
        else if (ResetDrag)
            rb.drag = PlayerPrefs.GetFloat("_Drag");

        if (SaveFreezeRotations)
            rb.freezeRotation = Convert.ToBoolean(PlayerPrefs.GetInt("FreezeRotation"));
        else if (ResetFreezeRotations)
            rb.freezeRotation = Convert.ToBoolean(PlayerPrefs.GetInt("_FreezeRotation"));

        if (SaveHideFlags)
            rb.hideFlags = (HideFlags)PlayerPrefs.GetInt("HideFlags");
        else if (ResetHideFlags)
            rb.hideFlags = (HideFlags)PlayerPrefs.GetInt("_HideFlags");

        if (SaveInertiaTensor)
        {
            x = PlayerPrefs.GetFloat("InertiaTensorX");
            y = PlayerPrefs.GetFloat("InertiaTensorY");
            z = PlayerPrefs.GetFloat("InertiaTensorZ");
            rb.inertiaTensor = new Vector3(x, y, z);
        }
        else if (ResetInertiaTensor)
        {
            x = PlayerPrefs.GetFloat("_InertiaTensorX");
            y = PlayerPrefs.GetFloat("_InertiaTensorY");
            z = PlayerPrefs.GetFloat("_InertiaTensorZ");
            rb.inertiaTensor = new Vector3(x, y, z);
        }

        if (SaveInertiaTensorRotation)
        {
            w = PlayerPrefs.GetFloat("InertiaTensorRotationW");
            x = PlayerPrefs.GetFloat("InertiaTensorRotationX");
            y = PlayerPrefs.GetFloat("InertiaTensorRotationY");
            z = PlayerPrefs.GetFloat("InertiaTensorRotationZ");
            rb.inertiaTensorRotation = new Quaternion(x, y, z, w);
        }
        else if (ResetInertiaTensorRotation)
        {
            w = PlayerPrefs.GetFloat("_InertiaTensorRotationW");
            x = PlayerPrefs.GetFloat("_InertiaTensorRotationX");
            y = PlayerPrefs.GetFloat("_InertiaTensorRotationY");
            z = PlayerPrefs.GetFloat("_InertiaTensorRotationZ");
            rb.inertiaTensorRotation = new Quaternion(x, y, z, w);
        }

        if (SaveInterpolation)
            rb.interpolation = (RigidbodyInterpolation)PlayerPrefs.GetInt("Interpolation");
        else if (ResetInterpolation)
            rb.interpolation = (RigidbodyInterpolation)PlayerPrefs.GetInt("_Interpolation");

        if (SaveIsKinematic)
            rb.isKinematic = Convert.ToBoolean(PlayerPrefs.GetInt("IsKinematic"));
        else if (ResetIsKinematic)
            rb.isKinematic = Convert.ToBoolean(PlayerPrefs.GetInt("_IsKinematic"));

        if (SaveMass)
            rb.mass = PlayerPrefs.GetFloat("Mass");
        else if (ResetMass)
            rb.mass = PlayerPrefs.GetFloat("_Mass");

        if (SaveMaxAngularVelocity)
            rb.maxAngularVelocity = PlayerPrefs.GetFloat("MaxAngularVelocity");
        else if (ResetMaxAngularVelocity)
            rb.maxAngularVelocity = PlayerPrefs.GetFloat("_MaxAngularVelocity");

        if (SaveMaxDepenetrationVelocity)
            rb.maxDepenetrationVelocity = PlayerPrefs.GetFloat("MaxDepenetrationVelocity");
        else if (ResetMaxDepenetrationVelocity)
            rb.maxDepenetrationVelocity = PlayerPrefs.GetFloat("_MaxDepenetrationVelocity");

        if (SaveName)
            rb.name = PlayerPrefs.GetString("Name");
        else if (ResetName)
            rb.name = PlayerPrefs.GetString("_Name");

        if (SavePosition)
        {
            x = PlayerPrefs.GetFloat("PositionX");
            y = PlayerPrefs.GetFloat("PositionY");
            z = PlayerPrefs.GetFloat("PositionZ");
            rb.position = new Vector3(x, y, z);
        }
        else if (ResetPosition)
        {
            x = PlayerPrefs.GetFloat("_PositionX");
            y = PlayerPrefs.GetFloat("_PositionY");
            z = PlayerPrefs.GetFloat("_PositionZ");
            rb.position = new Vector3(x, y, z);
        }

        if (SaveRotation)
        {
            w = PlayerPrefs.GetFloat("RotationW");
            x = PlayerPrefs.GetFloat("RotationX");
            y = PlayerPrefs.GetFloat("RotationY");
            z = PlayerPrefs.GetFloat("RotationZ");
            rb.rotation = new Quaternion(x, y, z, w);
        }
        else if (ResetRotation)
        {
            w = PlayerPrefs.GetFloat("_RotationW");
            x = PlayerPrefs.GetFloat("_RotationX");
            y = PlayerPrefs.GetFloat("_RotationY");
            z = PlayerPrefs.GetFloat("_RotationZ");
            rb.rotation = new Quaternion(x, y, z, w);
        }

        if (SaveSleepThreshold)
            rb.sleepThreshold = PlayerPrefs.GetFloat("SleepThreshold");
        else if (ResetSleepThreshold)
            rb.sleepThreshold = PlayerPrefs.GetFloat("_SleepThreshold");

        if (SaveSolverIterations)
            rb.solverIterations = PlayerPrefs.GetInt("SolverIterations");
        else if (ResetSolverIterations)
            rb.solverIterations = PlayerPrefs.GetInt("_SolverIterations");

        if (SaveSolverVelocityIterations)
            rb.solverVelocityIterations = PlayerPrefs.GetInt("SolverVelocityIterations");
        else if (ResetSolverVelocityIterations)
            rb.solverVelocityIterations = PlayerPrefs.GetInt("_SolverVelocityIterations");

        if (SaveTag)
            rb.tag = PlayerPrefs.GetString("Tag");
        else if (ResetTag)
            rb.tag = PlayerPrefs.GetString("_Tag");

        if (SaveUseConeFriction)
            rb.useConeFriction = Convert.ToBoolean(PlayerPrefs.GetInt("UseConeFriction"));
        else if (ResetUseConeFriction)
            rb.useConeFriction = Convert.ToBoolean(PlayerPrefs.GetInt("_UseConeFriction"));

        if (SaveUseGravity)
            rb.useGravity = Convert.ToBoolean(PlayerPrefs.GetInt("UseGravity"));
        else if (ResetUseGravity)
            rb.useGravity = Convert.ToBoolean(PlayerPrefs.GetInt("_UseGravity"));

        if (SaveVelocity)
        {
            x = PlayerPrefs.GetFloat("VelocityX");
            y = PlayerPrefs.GetFloat("VelocityY");
            z = PlayerPrefs.GetFloat("VelocityZ");
            rb.velocity = new Vector3(x, y, z);
        }
        else if (ResetVelocity)
        {
            x = PlayerPrefs.GetFloat("_VelocityX");
            y = PlayerPrefs.GetFloat("_VelocityY");
            z = PlayerPrefs.GetFloat("_VelocityZ");
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
