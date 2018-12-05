Shader "Tutorial/Basic" {
	Properties {
		_Color ("Main Color", Color) = (1.0, 0.0, 0.0, 1.0)
	}
	SubShader {
		Pass {
			Material {
				Diffuse [_Color]
			}
			Lighting On
		}
	}
}