#region Header Licence
//  ---------------------------------------------------------------------
// 
//  Copyright (c) 2009 Alexandre Mutel and Microsoft Corporation.  
//  All rights reserved.
// 
//  This code module is part of NShader, a plugin for visual studio
//  to provide syntax highlighting for shader languages (hlsl, glsl, cg)
// 
//  ------------------------------------------------------------------
// 
//  This code is licensed under the Microsoft Public License. 
//  See the file License.txt for the license details.
//  More info on: http://nshader.codeplex.com
// 
//  ------------------------------------------------------------------
#endregion
namespace NShader
{
    public class NShaderSupportedExtensions
    {
        // HLSL file extensions
        public const string HLSL_FX = ".fx";
        public const string HLSL_HLSL = ".hlsl";
        public const string HLSL_VSH = ".vsh";
        public const string HLSL_PSH = ".psh";

        // GLSL file extensions
        public const string GLSL_FRAG = ".frag";
        public const string GLSL_VERT = ".vert";
        public const string GLSL_FP = ".fp";
        public const string GLSL_VP = ".vp";
        public const string GLSL_GEOM = ".geom";
        public const string GLSL_GLSL = ".glsl";

        // CG file extensions
        public const string CG_CG = ".cg";
        public const string CG_CGFX = ".cgfx";
    }
}