CREATE TABLE users ( 
id INT AUTO_INCREMENT primary key,
username varchar(30) NOT NULL UNIQUE,
password varchar(30) NOT NULL,
email varchar(50) NOT NULL 
);

CREATE TABLE repositories(
id INT auto_increment PRIMARY KEY,
name varchar(50) NOT NULL
);

CREATE TABLE repositories_contributors(
repository_id int,
contributor_id int
);

ALTER TABLE repositories_contributors
ADD CONSTRAINT fk_repositories_contributors_repositories foreign key(repository_id)
references repositories(id);

ALTER TABLE repositories_contributors
ADD CONSTRAINT fk_repositories_contributors_repositoriese foreign key(contributor_id)
references users(id);

CREATE TABLE issues(
id int auto_increment primary KEY,
title varchar(255) NOT NULL,
issue_status varchar(6) NOT NULL,
repository_id int NOT NULL,
assignee_id INT NOT NULL
);


ALTER TABLE issues
ADD CONSTRAINT fk_issues_repositories foreign key(repository_id)
references repositories(id);

ALTER TABLE issues
ADD CONSTRAINT fk_issues_users foreign key(assignee_id)
references users(id);

CREATE TABLE commits (
id INT auto_increment primary KEY,
message varchar(255) NOT NULL,
issue_id INT,
repository_id INT NOT NULL,
contributor_id INT NOT NULL
);

ALTER TABLE commits
ADD CONSTRAINT fk_commits_issues foreign key(issue_id)
references issues(id);

ALTER TABLE commits
ADD CONSTRAINT fk_commits_repositories foreign key(repository_id)
references repositories(id);

ALTER TABLE commits
ADD CONSTRAINT fk_commists_users foreign key(contributor_id)
references users(id);


create TABLE files (
id INT auto_increment primary key,
name varchar(100) NOT NULL,
size DECIMAL(10,2) NOT NULL,
parent_id int,
commit_id INT NOT NULL
);

ALTER TABLE files
ADD CONSTRAINT fk_files_files foreign key(parent_id)
references files(id);


ALTER TABLE files
ADD CONSTRAINT fk_files_commits foreign key(commit_id)
references commits(id);
