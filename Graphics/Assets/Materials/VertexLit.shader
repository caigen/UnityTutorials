Shader "Tutorial/VertexLit" {
	Properties {
		_Color ("Main Color", Color) = (1.0, 1.0, 1.0, 0.5)
		_SpecColor ("Spec Color", Color) = (1.0, 1.0, 1.0, 1.0)
		_Emission ("Emissive Color", Color) = (0.0, 0.0, 0.0, 0.0)
		_Shininess ("Shininess", Range(0.01, 1.0)) = 0.7
		_MainTex ("Base Texture (RGB)", 2D) = "white" {}
	}
	SubShader {
		Pass {
			Material {
				Diffuse [_Color]
				Ambient [_Color]
				Shininess [_Shininess]
				Specular [_SpecColor]
				Emission [_Emission]
			}
			Lighting On
			SeparateSpecular On
			SetTexture [_MainTex] {
				constantColor [_Color]
				Combine texture * primary DOUBLE, texture * constant
			}
		}
	}
}
