node {
	def application

		stage ('Clone repository'){
			checkout scm
		}
		
		//stage('Restore Nuget'){
		//	bat 'C:/tools/nuget.exe restore TemperatureApp.sln'
		//}

 	
		stage('Building application'){

			bat "\"${tool 'MSBuild'}msbuild.exe\" TemperatureApp.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
		}
		
		stage('Testing Unit')
			bat 'C:/tools/NUnit.org/nunit-console/nunit3-console.exe UnitTestTemperature/bin/Debug/net6.0/UnitTestTemperature.dll'
											

	
}
