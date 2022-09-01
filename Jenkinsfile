node {
	def application

		stage("Clone repository"){
			checkout scm
		}

 	
		stage('Building application'){
			bat "\"${msbuild}\" TemperatureApp.sln "
		}
		stage("test"){
		}

	
}
