import { promises as fs, statSync } from "fs";
import { join } from "path";

const GLOBAL = "./";

fs.readdir(GLOBAL)
    .then(async (files) => {
        const projects = files.filter((file) =>
            statSync(join(GLOBAL, file)).isDirectory() &&
            !file.startsWith(".") &&
            file !== "node_modules" &&
            file !== "test"
        );

        for (const project of projects) {
            const projectDir = `${GLOBAL}/${project}`;

            console.log(project);

            await fs.readdir(projectDir)
                .then(async (files) => {
                    files = files.filter((file) => file.endsWith(".json"));

                    for (const file of files) {
                        try {
                            const translation = await import(`${projectDir}/${file}`);

                            console.log(`   ✓ ${file}`);
                        } catch (error) {
                            throw `   ✘ ${file} - ${error}`;
                        }
                    }
                });
        }
    });