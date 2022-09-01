node {
	def application

		stage("Clone repository"){
			checkout scm
		}

 	
		stage('Building application'){
			bat "\"${'tool MSBuild'}\" TemperatureApp.sln "
		}
		stage("test"){
		}

	
}
