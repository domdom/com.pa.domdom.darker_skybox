#version 140

// skybox_background.fs

#ifdef GL_ES
precision mediump float;
#endif

uniform samplerCube SkyboxTexture;
uniform vec4 Color;

in vec3 v_SkyboxDir;

out vec4 out_FragColor;

void main() 
{
    vec4 texel = texture(SkyboxTexture, v_SkyboxDir);
    // out_FragColor = vec4(mix(texel.xyz, Color.xyz, Color.w), 0.01);
    out_FragColor = vec4(mix(mix(texel.xyz, Color.xyz, Color.w), vec3(0, 0, 0), 0.95), 0.01);
}
