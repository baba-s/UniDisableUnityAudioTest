using NUnit.Framework;
using System.Linq;
using UnityEditor;

namespace Kogane.Internal
{
	internal sealed class DisableUnityAudioTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void Disable_Unity_Audio_が有効になっているか()
		{
			var path             = "ProjectSettings/AudioManager.asset";
			var manager          = AssetDatabase.LoadAllAssetsAtPath( path ).FirstOrDefault();
			var serializedObject = new SerializedObject( manager );
			var property         = serializedObject.FindProperty( "m_DisableAudio" );

			Assert.IsTrue( property.boolValue );
		}
	}
}